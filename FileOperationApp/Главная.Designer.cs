namespace FileOperationApp
{
    partial class Главная
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборМетодаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копированиеФайловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копированиеДиректорийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеФайлаПоИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеФайловПоНаборуИменToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеФайловПоМаскеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСловаВФайлеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСловаВПапкеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборМетодаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборМетодаToolStripMenuItem
            // 
            this.выборМетодаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копированиеФайловToolStripMenuItem,
            this.копированиеДиректорийToolStripMenuItem,
            this.удалениеФайлаПоИмениToolStripMenuItem,
            this.удалениеФайловПоНаборуИменToolStripMenuItem,
            this.удалениеФайловПоМаскеToolStripMenuItem,
            this.переносФайлаToolStripMenuItem,
            this.поискСловаВФайлеToolStripMenuItem,
            this.поискСловаВПапкеToolStripMenuItem});
            this.выборМетодаToolStripMenuItem.Name = "выборМетодаToolStripMenuItem";
            this.выборМетодаToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.выборМетодаToolStripMenuItem.Text = "Выбор метода ";
            // 
            // копированиеФайловToolStripMenuItem
            // 
            this.копированиеФайловToolStripMenuItem.Name = "копированиеФайловToolStripMenuItem";
            this.копированиеФайловToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.копированиеФайловToolStripMenuItem.Text = "Копирование файлов";
            this.копированиеФайловToolStripMenuItem.Click += new System.EventHandler(this.копированиеФайловToolStripMenuItem_Click);
            // 
            // копированиеДиректорийToolStripMenuItem
            // 
            this.копированиеДиректорийToolStripMenuItem.Name = "копированиеДиректорийToolStripMenuItem";
            this.копированиеДиректорийToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.копированиеДиректорийToolStripMenuItem.Text = "Копирование директорий";
            this.копированиеДиректорийToolStripMenuItem.Click += new System.EventHandler(this.копированиеДиректорийToolStripMenuItem_Click);
            // 
            // удалениеФайлаПоИмениToolStripMenuItem
            // 
            this.удалениеФайлаПоИмениToolStripMenuItem.Name = "удалениеФайлаПоИмениToolStripMenuItem";
            this.удалениеФайлаПоИмениToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.удалениеФайлаПоИмениToolStripMenuItem.Text = "Удаление файла по имени";
            this.удалениеФайлаПоИмениToolStripMenuItem.Click += new System.EventHandler(this.удалениеФайлаПоИмениToolStripMenuItem_Click);
            // 
            // удалениеФайловПоНаборуИменToolStripMenuItem
            // 
            this.удалениеФайловПоНаборуИменToolStripMenuItem.Name = "удалениеФайловПоНаборуИменToolStripMenuItem";
            this.удалениеФайловПоНаборуИменToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.удалениеФайловПоНаборуИменToolStripMenuItem.Text = "Удаление файлов по набору имен";
            this.удалениеФайловПоНаборуИменToolStripMenuItem.Click += new System.EventHandler(this.удалениеФайловПоНаборуИменToolStripMenuItem_Click);
            // 
            // удалениеФайловПоМаскеToolStripMenuItem
            // 
            this.удалениеФайловПоМаскеToolStripMenuItem.Name = "удалениеФайловПоМаскеToolStripMenuItem";
            this.удалениеФайловПоМаскеToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.удалениеФайловПоМаскеToolStripMenuItem.Text = "Удаление файлов по маске";
            this.удалениеФайловПоМаскеToolStripMenuItem.Click += new System.EventHandler(this.удалениеФайловПоМаскеToolStripMenuItem_Click);
            // 
            // переносФайлаToolStripMenuItem
            // 
            this.переносФайлаToolStripMenuItem.Name = "переносФайлаToolStripMenuItem";
            this.переносФайлаToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.переносФайлаToolStripMenuItem.Text = "Перенос файла";
            this.переносФайлаToolStripMenuItem.Click += new System.EventHandler(this.переносФайлаToolStripMenuItem_Click);
            // 
            // поискСловаВФайлеToolStripMenuItem
            // 
            this.поискСловаВФайлеToolStripMenuItem.Name = "поискСловаВФайлеToolStripMenuItem";
            this.поискСловаВФайлеToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.поискСловаВФайлеToolStripMenuItem.Text = "Поиск слова в файле";
            this.поискСловаВФайлеToolStripMenuItem.Click += new System.EventHandler(this.поискСловаВФайлеToolStripMenuItem_Click);
            // 
            // поискСловаВПапкеToolStripMenuItem
            // 
            this.поискСловаВПапкеToolStripMenuItem.Name = "поискСловаВПапкеToolStripMenuItem";
            this.поискСловаВПапкеToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.поискСловаВПапкеToolStripMenuItem.Text = "Поиск слова в папке";
            this.поискСловаВПапкеToolStripMenuItem.Click += new System.EventHandler(this.поискСловаВПапкеToolStripMenuItem_Click);
            // 
            // Главная
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Главная";
            this.Text = "Главная";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборМетодаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копированиеФайловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копированиеДиректорийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеФайлаПоИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеФайловПоНаборуИменToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеФайловПоМаскеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переносФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискСловаВФайлеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискСловаВПапкеToolStripMenuItem;
    }
}