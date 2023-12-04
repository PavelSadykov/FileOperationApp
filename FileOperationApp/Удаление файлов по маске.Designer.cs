namespace FileOperationApp
{
    partial class Удаление_файлов_по_маске
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
            this.textBoxToFile = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPathToFolder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFolderSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxToFile
            // 
            this.textBoxToFile.Location = new System.Drawing.Point(32, 191);
            this.textBoxToFile.Multiline = true;
            this.textBoxToFile.Name = "textBoxToFile";
            this.textBoxToFile.Size = new System.Drawing.Size(180, 29);
            this.textBoxToFile.TabIndex = 18;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(218, 191);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 29);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Укажите в каждой строке маску файла  для удаления";
            // 
            // labelPathToFolder
            // 
            this.labelPathToFolder.AutoSize = true;
            this.labelPathToFolder.Location = new System.Drawing.Point(143, 95);
            this.labelPathToFolder.Name = "labelPathToFolder";
            this.labelPathToFolder.Size = new System.Drawing.Size(34, 13);
            this.labelPathToFolder.TabIndex = 15;
            this.labelPathToFolder.Text = ".........";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Путь к папке:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выберите папку где расположены файлы для удаления";
            // 
            // buttonFolderSelect
            // 
            this.buttonFolderSelect.Location = new System.Drawing.Point(213, 50);
            this.buttonFolderSelect.Name = "buttonFolderSelect";
            this.buttonFolderSelect.Size = new System.Drawing.Size(106, 30);
            this.buttonFolderSelect.TabIndex = 12;
            this.buttonFolderSelect.Text = "Выбрать папку";
            this.buttonFolderSelect.UseVisualStyleBackColor = true;
            // 
            // Удаление_файлов_по_маске
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxToFile);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPathToFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFolderSelect);
            this.Name = "Удаление_файлов_по_маске";
            this.Text = "Удаление файлов по маске";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxToFile;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPathToFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFolderSelect;
    }
}