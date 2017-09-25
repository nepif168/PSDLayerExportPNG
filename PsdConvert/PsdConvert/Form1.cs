using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using System.IO;
using System.Drawing.PSD;

namespace PsdConvert
{
    public partial class Form1 : Form
    {
        string filePath = null;
        string folderPath = null;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                filePath = fileTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FolderSelectButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                folderPath = folderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folderPath) || string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("ファイルまたはフォルダが選択されていません");
                return;
            }

            PsdFile psd = new PsdFile();
            psd.Load(filePath);
            List<string> layerName = new List<string>();
            foreach (var layer in psd.Layers)
            {
                layerName.Add(layer.Name);
            }

            using (MagickImageCollection imgs = new MagickImageCollection(filePath))
            {
                for (int i = 0; i < imgs.Count; i++)
                {
                    imgs[i].GifDisposeMethod = GifDisposeMethod.Background;
                }

                imgs.Coalesce();

                for (int i = 0; i < imgs.Count; i++)
                {
                    imgs[i].GifDisposeMethod = GifDisposeMethod.Background;
                    string saveFileName;
                    try
                    {
                        saveFileName = Path.Combine(folderPath, layerName[i] + ".png");
                    }
                    catch
                    {
                        saveFileName = "error_name";
                    }

                    imgs[i].Write(saveFileName);
                }

                imgs.RemoveAt(0);
            }



            //Application.Exit();
        }
    }
}
