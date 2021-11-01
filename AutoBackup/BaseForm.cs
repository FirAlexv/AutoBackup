using AutoBackup.Properties;
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

namespace AutoBackup
{
    public partial class BaseForm : Form
    {
        Settings settings = new Settings();


        public BaseForm()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (settings.Path_Source == "" && settings.Path_Backup == "")
            {
                if (textBox_Path_Source.Text == "" && textBox_Path_Backup.Text == "")
                {
                    MessageBox.Show("Пути пусты!");
                }
                else
                {
                    settings.Path_Source = textBox_Path_Source.Text;

                    settings.Path_Backup = textBox_Path_Backup.Text;

                    MyAutoBackup(settings.Path_Source, settings.Path_Backup);
                }
            }
            else
            {
                textBox_Path_Source.Text = settings.Path_Source;

                textBox_Path_Backup.Text = settings.Path_Backup;

                MyAutoBackup(settings.Path_Source, settings.Path_Backup);
            }            
        }

        private void Button_Path_Source_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            textBox_Path_Source.Text = folderBrowserDialog.SelectedPath;
        }

        private void Button_Path_Backup_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            textBox_Path_Backup.Text = folderBrowserDialog.SelectedPath;
        }

        private void MyAutoBackup(string path_Source, string path_Backup)
        {
            string[] fileCollectSource = Directory.GetFiles(settings.Path_Source);
            string[] fileCollectBackup = Directory.GetFiles(settings.Path_Backup);

            for (int i = 0; i < fileCollectSource.Length; i++)
            {
                FileInfo fileSource = new FileInfo(fileCollectSource[i]);
                FileInfo fileBackup;

                if (fileCollectBackup.Length!=0)//Пустота резерва
                {
                    fileBackup = new FileInfo(fileCollectBackup[i]);

                    if (fileSource.LastWriteTime > fileBackup.LastWriteTime)
                    {
                        fileSource.CopyTo(fileBackup.FullName, true);
                    }
                }
                else
                {
                    fileSource.CopyTo(settings.Path_Backup+"\\"+fileSource.Name, true);
                }
            }
            //todo Доделать пробег по папкам
        }
    }
}
