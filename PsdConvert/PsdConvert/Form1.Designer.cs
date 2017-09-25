namespace PsdConvert
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileSelectButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.FolderSelectButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.executeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = ".*psd|";
            // 
            // FileSelectButton
            // 
            this.FileSelectButton.Location = new System.Drawing.Point(404, 33);
            this.FileSelectButton.Name = "FileSelectButton";
            this.FileSelectButton.Size = new System.Drawing.Size(75, 23);
            this.FileSelectButton.TabIndex = 0;
            this.FileSelectButton.Text = "ファイル選択";
            this.FileSelectButton.UseVisualStyleBackColor = true;
            this.FileSelectButton.Click += new System.EventHandler(this.FileSelectButton_Click);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(75, 74);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(314, 19);
            this.folderTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "psdファイル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "保存先";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(75, 38);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(314, 19);
            this.fileTextBox.TabIndex = 4;
            this.fileTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FolderSelectButton
            // 
            this.FolderSelectButton.Location = new System.Drawing.Point(404, 72);
            this.FolderSelectButton.Name = "FolderSelectButton";
            this.FolderSelectButton.Size = new System.Drawing.Size(75, 23);
            this.FolderSelectButton.TabIndex = 3;
            this.FolderSelectButton.Text = "フォルダ選択";
            this.FolderSelectButton.UseVisualStyleBackColor = true;
            this.FolderSelectButton.Click += new System.EventHandler(this.FolderSelectButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(212, 111);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 6;
            this.executeButton.Text = "実行";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 146);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.FolderSelectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.FileSelectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FileSelectButton;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button FolderSelectButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button executeButton;
    }
}

