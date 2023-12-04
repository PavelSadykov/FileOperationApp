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
    public partial class Перенос_файла : Form
    {
        public Перенос_файла()
        {
            InitializeComponent();
            SelectFileButton.Click += SelectFileButton_Click; // Назначение обработчика события кнопке

        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
           
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Выберите файл для копирования";
                openFileDialog.Filter = "All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFilePath = openFileDialog.FileName;

                    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                    {
                        folderBrowserDialog.Description = "Выберите целевую директорию для копирования файла";

                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {


                            string destinationDir = folderBrowserDialog.SelectedPath;
                            string sourceFileName = Path.GetFileName(sourceFilePath);
                            string destinationFilePath = Path.Combine(destinationDir, sourceFileName);
                            if (File.Exists(sourceFilePath))
                            {
                                FileOparations.MoveFile(sourceFilePath, destinationFilePath);
                                MessageBox.Show($"Файл {sourceFileName} успешно перемещен!");
                            }
                            else
                            {
                                MessageBox.Show($"Файл {sourceFileName}  не найден в исходной директории");
                            }


                        }
                    }
                }
            }
        }
    }
}

