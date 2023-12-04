using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_FileSystemOperations;

namespace FileOperationApp
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
            MessageBox.Show("Нажмите кнопку *ОК* \nЗатем выберите метод для работы с файловой системой ");
        }

        private void копированиеФайловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Копирование_файлов copyFileForm = new Копирование_файлов();
            copyFileForm.Show();
        }

        private void копированиеДиректорийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Копирование_директорий copyDirectoryForm = new Копирование_директорий();
            copyDirectoryForm.Show();
        }

        private void удалениеФайлаПоИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Удаление_файла_по_имени delFileByName = new Удаление_файла_по_имени();
            delFileByName.Show();
        }

        private void удалениеФайловПоНаборуИменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Удаление_файлов_по_набору_имен delFileBySetOfNames = new Удаление_файлов_по_набору_имен();
            delFileBySetOfNames.Show();
        }

        private void удалениеФайловПоМаскеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Удаление_файлов_по_маске delFileByMask = new Удаление_файлов_по_маске();
            delFileByMask.Show();
        }

        private void переносФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Перенос_файла transferringFile = new Перенос_файла();
            transferringFile.Show();
        }
        
        private void поискСловаВФайлеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поиск_слова_в_файле searchWordInFile = new Поиск_слова_в_файле();
            searchWordInFile.Show();
        }
        
        private void поискСловаВПапкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Поиск_слова__в_папке searchWordInDirectory = new Поиск_слова__в_папке();
            searchWordInDirectory.Show();   
        }
    }
}
