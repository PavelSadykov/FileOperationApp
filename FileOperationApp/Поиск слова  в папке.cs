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
using ClassLibrary_FileSystemOperations;

namespace FileOperationApp
{
    public partial class Поиск_слова__в_папке : Form
    {
        public Поиск_слова__в_папке()
        {
            InitializeComponent();
            SelectDirectoryButton1.Click += SelectDirectoryButton1_Click; // Назначение обработчика события кнопке

        }


        private void SelectDirectoryButton1_Click(object sender, EventArgs e)
        {
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Выберите исходную директорию";//Комментарий на окне

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sourceDirPath = folderBrowserDialog.SelectedPath;
                        SourceLabelPath.Text = sourceDirPath;


                    }
                }

            }
        }
        //Этот метод должен быть в   public static class FileOparations. Там он и есть. Но не вызывается из этого класса.
        // Ддя проверки оставил пока что этот метод здесь.
        public List<string> SearchWordInFolder(string folderPath, string searchTerm)
        {
            List<string> matchingFiles = new List<string>();// список строк для хранения путей к файлам где слово найдено
            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, "*.txt");//cоздаем массив строк
                                                                         //содержащих пути к файлам txt в папке
                foreach (string file in files) // перебираем их
                {
                    string content = File.ReadAllText(file);//считываем все текстовые данные из каждого файла

                    if (content.Contains(searchTerm))
                    {
                        matchingFiles.Add(file);// добавляем путь в коллекцию

                    }
                }
            }

            return matchingFiles;//возвращаем коллекцию путей к файлам (где есть слово)
        }
        private void buttonInputWord_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxInputWord.Text.Trim();
            string folderPath = SourceLabelPath.Text.Trim();
            // файл с отчетом
            string reportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Report.txt");

            using (StreamWriter writer = new StreamWriter(reportPath))
            {

                // List<string> matchingFiles = FileOparations.SearchWordInFolder(folderPath, searchTerm);
                //Как говорил выше, По непонятным пока что причинам не представилось возможным передать все в обработку в FileOparation.
                //Проект (решение) не запускалось.
                //Пришлось проверить работоспособность внутри класса Формы. Работает. Продолжаю искать способ, как передать в FileOparation
                List<string> matchingFiles = SearchWordInFolder(folderPath, searchTerm);

                if (matchingFiles.Count > 0)
                {
                    foreach (string file in matchingFiles)
                    {
                        writer.WriteLine($"По адресу: {file}");
                        writer.WriteLine($"слово '{searchTerm}' найдено.");
                        MessageBox.Show($"Слово {searchTerm} найдено по адресу: {file}");
                    }
                }
                else
                {
                    writer.WriteLine($"По адресу {folderPath}");
                    writer.WriteLine($"слово '{searchTerm}' не найдено.");
                    MessageBox.Show($"Слово {searchTerm} в папке {folderPath} не найдено") ;
                }

            }
        }
    }
}