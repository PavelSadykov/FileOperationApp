using ClassLibrary_FileSystemOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOperationApp
{
    public partial class Копирование_файлов : Form
    {
        public Копирование_файлов()
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
                           string destinationFolderPath = folderBrowserDialog.SelectedPath;

                            string sourceFileName = Path.GetFileName(sourceFilePath);
                            string destinationFilePath = Path.Combine(destinationFolderPath, sourceFileName);
                            if (!string.IsNullOrEmpty(sourceFilePath) && !string.IsNullOrEmpty(destinationFilePath))
                            {
                                FileOparations.CopyFile(sourceFilePath, destinationFilePath);
                                MessageBox.Show("Файл успешно скопирован!");
                            }
                            else
                            {
                                MessageBox.Show("Укажите путь целевой директории");
                            }


                        }
                    }
                }
            }
        }

    }
} 


    
    
