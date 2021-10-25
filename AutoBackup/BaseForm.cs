using AutoBackup.Properties;
using System;
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

        string Path_Source = "", Path_Backup = "";

        public BaseForm()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_Path_Source.Text == "" && textBox_Path_Backup.Text == "")
            {
                settings.Path_Source = Path_Source;

                settings.Path_Backup = Path_Backup;
            }
            else
            {
                settings.Path_Source = textBox_Path_Source.Text;

                settings.Path_Backup = textBox_Path_Backup.Text;
            }

            MyAutoBakap(settings.Path_Source, settings.Path_Backup);
        }

        private void button_Path_Source_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            Path_Source = folderBrowserDialog.SelectedPath;
        }

        private void button_Path_Backup_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();

            Path_Backup = folderBrowserDialog.SelectedPath;
        }

        private void MyAutoBakap(string path_Source, string path_Backup)
        {
            //todo Доделать
        }
    }
}
