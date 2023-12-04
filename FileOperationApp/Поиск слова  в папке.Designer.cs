namespace FileOperationApp
{
    partial class Поиск_слова__в_папке
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceLabelPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectDirectoryButton1 = new System.Windows.Forms.Button();
            this.textBoxInputWord = new System.Windows.Forms.TextBox();
            this.buttonInputWord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceLabelPath
            // 
            this.SourceLabelPath.AutoSize = true;
            this.SourceLabelPath.Location = new System.Drawing.Point(128, 98);
            this.SourceLabelPath.Name = "SourceLabelPath";
            this.SourceLabelPath.Size = new System.Drawing.Size(25, 13);
            this.SourceLabelPath.TabIndex = 8;
            this.SourceLabelPath.Text = "......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Путь к папке:";
            // 
            // SelectDirectoryButton1
            // 
            this.SelectDirectoryButton1.Location = new System.Drawing.Point(49, 51);
            this.SelectDirectoryButton1.Name = "SelectDirectoryButton1";
            this.SelectDirectoryButton1.Size = new System.Drawing.Size(162, 23);
            this.SelectDirectoryButton1.TabIndex = 9;
            this.SelectDirectoryButton1.Text = "Выберите папку";
            this.SelectDirectoryButton1.UseVisualStyleBackColor = true;
            this.SelectDirectoryButton1.Click += new System.EventHandler(this.SelectDirectoryButton1_Click);
            // 
            // textBoxInputWord
            // 
            this.textBoxInputWord.Location = new System.Drawing.Point(49, 157);
            this.textBoxInputWord.Name = "textBoxInputWord";
            this.textBoxInputWord.Size = new System.Drawing.Size(162, 20);
            this.textBoxInputWord.TabIndex = 10;
            // 
            // buttonInputWord
            // 
            this.buttonInputWord.Location = new System.Drawing.Point(131, 183);
            this.buttonInputWord.Name = "buttonInputWord";
            this.buttonInputWord.Size = new System.Drawing.Size(80, 23);
            this.buttonInputWord.TabIndex = 11;
            this.buttonInputWord.Text = "ENTER";
            this.buttonInputWord.UseVisualStyleBackColor = true;
            this.buttonInputWord.Click += new System.EventHandler(this.buttonInputWord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите слово для поиска";
            // 
            // Поиск_слова__в_папке
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonInputWord);
            this.Controls.Add(this.textBoxInputWord);
            this.Controls.Add(this.SelectDirectoryButton1);
            this.Controls.Add(this.SourceLabelPath);
            this.Controls.Add(this.label1);
            this.Name = "Поиск_слова__в_папке";
            this.Text = "Поиск слова в папке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SourceLabelPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectDirectoryButton1;
        private System.Windows.Forms.TextBox textBoxInputWord;
        private System.Windows.Forms.Button buttonInputWord;
        private System.Windows.Forms.Label label2;
    }
}