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

namespace FileOperationApp
{
    public partial class Удаление_файлов_по_набору_имен : Form
    {
        public Удаление_файлов_по_набору_имен()
        {
            InitializeComponent();
            buttonFolderSelect.Click += buttonFolderSelect_Click;//обработчик события
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

            List<string> fileNamesToDelete = new List<string>();//создаем список файлов для удаления
            string sourceDirPath = labelPathToFolder.Text;//считали путь папки с формы

            //получаем из грида список имен файлов и разделяем их по переносу строки:
            string[] fileNames = textBoxToFile.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);// ввели имя файла
            try
            {
                foreach (string fileName in fileNames) //перебираем
                {
                    fileNamesToDelete.Add(fileName);//добавляем в список
                    string filePath = Path.Combine(sourceDirPath, fileName);// объединяем файл и путь
                    if (File.Exists(filePath))
                    {
                        FileOparations.DeleteFiles(filePath);// отправляем в метод на удаление
                        MessageBox.Show($"Файл {fileName} успешно удален");
                    }
                    else
                    {
                        MessageBox.Show($"Файл {fileName} не существует в указанной папке");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении файла  : {ex.Message}");
            }

        }

       
    }
}