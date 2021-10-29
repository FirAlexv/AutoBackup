﻿using AutoBackup.Properties;
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

        //todo НЕ нужные переменные?
        string Path_Source = "", Path_Backup = "";

        public BaseForm()
        {
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Path_Source.Text == "" && textBox_Path_Backup.Text == "")
            {
                //todo Ошибка путей
                settings.Path_Source = Path_Source;

                settings.Path_Backup = Path_Backup;
            }
            else
            {
                settings.Path_Source = textBox_Path_Source.Text;

                settings.Path_Backup = textBox_Path_Backup.Text;
            }

            MyAutoBackup(settings.Path_Source, settings.Path_Backup);
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

            foreach (var file in fileCollectSource)
            {
                if (true)
                {

                }
            }
            //FileInfo fileSource= new FileInfo(settings.Path_Source);
            //todo Доделать
        }
    }
}
