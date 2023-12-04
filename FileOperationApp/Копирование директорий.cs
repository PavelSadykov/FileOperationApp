using System;
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
    public partial class Копирование_директорий : Form
    {
        public Копирование_директорий()
        {
            InitializeComponent();
            selectDirectoryButton.Click += SelectDirectoryButton_Click; // Назначение обработчика события кнопке
           
        }


        private void SelectDirectoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Выберите исходную директорию";//Комментарий на окне

                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sourceDirPath = folderBrowserDialog.SelectedPath;

                        using (FolderBrowserDialog destinationBrowserDialog = new FolderBrowserDialog())
                        {
                            destinationBrowserDialog.Description = "Выберите целевую директорию";//Комментарий на окне

                            if (destinationBrowserDialog.ShowDialog() == DialogResult.OK)
                            {
                                string destinationDirPath = destinationBrowserDialog.SelectedPath;
                                if (!string.IsNullOrEmpty(sourceDirPath) && !string.IsNullOrEmpty(destinationDirPath))
                                {
                                    FileOparations.CopyDirectory(sourceDirPath, destinationDirPath);//отправляем в обработку 
                                    MessageBox.Show("Директория успешно скопирована!");
                                }
                                else
                                {
                                    MessageBox.Show("Укажите пути исходной и целевой директорий");
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при копировании директории: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
