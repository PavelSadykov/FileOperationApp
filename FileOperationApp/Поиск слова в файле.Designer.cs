namespace FileOperationApp
{
    partial class Поиск_слова_в_файле
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
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchWord = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SourceLabelPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(22, 28);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(186, 32);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "Выберите файл";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь к файлу:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите слово для поиска в файле";
            // 
            // textBoxSearchWord
            // 
            this.textBoxSearchWord.Location = new System.Drawing.Point(22, 149);
            this.textBoxSearchWord.Name = "textBoxSearchWord";
            this.textBoxSearchWord.Size = new System.Drawing.Size(186, 20);
            this.textBoxSearchWord.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(133, 175);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "ENTER";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // SourceLabelPath
            // 
            this.SourceLabelPath.AutoSize = true;
            this.SourceLabelPath.Location = new System.Drawing.Point(105, 85);
            this.SourceLabelPath.Name = "SourceLabelPath";
            this.SourceLabelPath.Size = new System.Drawing.Size(25, 13);
            this.SourceLabelPath.TabIndex = 6;
            this.SourceLabelPath.Text = "......";
            // 
            // Поиск_слова_в_файле
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SourceLabelPath);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearchWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFileButton);
            this.Name = "Поиск_слова_в_файле";
            this.Text = "Поиск слова в файле";
            this.Click += new System.EventHandler(this.SelectFileButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearchWord;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label SourceLabelPath;
    }
}