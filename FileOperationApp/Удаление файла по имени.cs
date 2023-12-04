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
    public partial class Удаление_файла_по_имени : Form
    {
        public Удаление_файла_по_имени()
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
            string fileName = textBoxFileToDelete.Text;// ввели имя файла
            string sourceDirPath = labelPathToFolder.Text;//считали путь папки с формы
            string filePath = Path.Combine(sourceDirPath, fileName); //объединяем данные о пути и имени в одну строковую переменную
            try
            {
                if(File.Exists(filePath))// проверяем наличие
                {
                    FileOparations.DeleteFile(filePath);// отправляем в метод удаления
                    MessageBox.Show($"Файл {fileName} успешно удален");
                }
                else
                {
                    MessageBox.Show($"Файл {fileName} не существует в указанной папке");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении файла {fileName} : {ex.Message}");
            }
           
        }
    }
}
