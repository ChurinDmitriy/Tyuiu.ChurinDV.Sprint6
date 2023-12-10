using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChurinDV.Sprint6.Task7.V5.Lib;
using System.IO;

namespace Tyuiu.ChurinDV.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_CDV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_CDV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_CDV_Click(object sender, EventArgs e)
        {
            FormAbout_CDV formAbout = new FormAbout_CDV();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_CDV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CDV.ShowDialog();
            openFilePath = openFileDialogTask_CDV.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInputMatrix_CDV.ColumnCount = colums;
            dataGridViewInputMatrix_CDV.RowCount = rows;
            dataGridViewOutputMatrix_CDV.ColumnCount = colums;
            dataGridViewOutputMatrix_CDV.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInputMatrix_CDV.Columns[i].Width = 25;
                dataGridViewOutputMatrix_CDV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInputMatrix_CDV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_CDV.Enabled = true;
        }

        private void buttonSaveFile_CDV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_CDV.FileName = "OutPutFileTask7V5.csv";
            saveFileDialogMatrix_CDV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_CDV.ShowDialog();

            string path = saveFileDialogMatrix_CDV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutputMatrix_CDV.RowCount;
            int colums = dataGridViewOutputMatrix_CDV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOutputMatrix_CDV.Rows[i].Cells[j].Value + ';';
                    }
                    else
                    {
                        str = str + dataGridViewOutputMatrix_CDV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_CDV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutputMatrix_CDV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_CDV.Enabled = true;
        }
    }
}
