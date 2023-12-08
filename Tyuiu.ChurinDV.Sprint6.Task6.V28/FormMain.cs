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
using Tyuiu.ChurinDV.Sprint6.Task6.V28.Lib;

namespace Tyuiu.ChurinDV.Sprint6.Task6.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonHelp_CDV_Click(object sender, EventArgs e)
        {
            FormAbout_CDV formAbout = new FormAbout_CDV();
            formAbout.ShowDialog();
        }

        string openFilePath;

        private void buttonOpenFile_CDV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_CDV.ShowDialog();
                openFilePath = openFileDialogTask_CDV.FileName;
                textBoxInput_CDV.Text = File.ReadAllText(openFilePath);
                groupBoxOutputData_CDV.Text = groupBoxOutputData_CDV.Text + " " + openFileDialogTask_CDV.FileName;
                buttonDone_CDV.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберете файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_CDV_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOutput_CDV.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
