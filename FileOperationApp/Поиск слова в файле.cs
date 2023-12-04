using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary_FileSystemOperations;

namespace FileOperationApp
{
    public partial class Поиск_слова_в_файле : Form
    {
        public Поиск_слова_в_файле()
        {
            InitializeComponent();
            SelectFileButton.Click += SelectFileButton_Click; // Назначение обработчика события кнопке

        }


        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите текстовый файл для поиска слова";
                openFileDialog.Filter = "Text files  (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;
                    SourceLabelPath.Text = sourceFilePath;
                }
            }
        }
       
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string wordToSearch = textBoxSearchWord.Text;
            string sourceFilePath = SourceLabelPath.Text;
            try
            {
                string reportPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Report.txt");

                using (StreamWriter writer = new StreamWriter(reportPath))
                {
                   
                if (FileOparations.SearchWordInFile(sourceFilePath, wordToSearch))
            {
                    writer.WriteLine($"В файле по адресу: {sourceFilePath}");
                    writer.WriteLine($"слово '{wordToSearch}' найдено.");
                    MessageBox.Show($"Слово '{wordToSearch}' найдено в файле. Результат поиска записан в отчет {reportPath}");
            }
            else
            {
                     writer.WriteLine($"В файле по адресу: {sourceFilePath}");
                     writer.WriteLine($"Слово '{wordToSearch}' не найдено.");
                     MessageBox.Show($"Слово '{wordToSearch}' не найдено в файле. Результат поиска записан в отчет {reportPath}"); 
            }
            
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при создании отчета: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

    }
}


  

       