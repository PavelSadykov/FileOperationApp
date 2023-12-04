using ClassLibrary_FileSystemOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace FileOperationApp
{
    public partial class Удаление_файлов_по_маске : Form
    {
        public Удаление_файлов_по_маске()
        {
            InitializeComponent(); buttonFolderSelect.Click += buttonFolderSelect_Click;//обработчик события
        }

        private void buttonFolderSelect_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())//поиск папки через диалоговое окно
            {
                folderBrowserDialog.Description = "Выберите исходную директорию";//Комментарий на окне

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceDirPath = folderBrowserDialog.SelectedPath;
                    labelPathToFolder.Text = sourceDirPath; // записали путь папки на форму
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string sourceDirPath = labelPathToFolder.Text;//считали путь папки с формы
            string fileMask = textBoxToFile.Text;//считали маску
            try
            {
                
                string[] matchFiles = Directory.GetFiles(sourceDirPath,fileMask); //создали массив строк файлов с одинаковыми масками 
                if (matchFiles.Length > 0) //если они имеются в папке
                {
                    FileOparations.DeleteFilesByMask(sourceDirPath, fileMask);// отправляем в метод на удаление
                    foreach (string file in matchFiles) //перебираем и выводим итог
                    {
                        MessageBox.Show($"Файл {file} успешно удален");
                    }
                }
                else
                {
                    MessageBox.Show($"Файл не существует в указанной папке");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении файла  : {ex.Message}");
            }

        }


    }
}