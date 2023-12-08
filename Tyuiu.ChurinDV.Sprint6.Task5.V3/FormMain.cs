using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChurinDV.Sprint6.Task5.V3.Lib;
using System.IO;

namespace Tyuiu.ChurinDV.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint6\Tyuiu.ChurinDV.Sprint6.Task5.V3\bin\Debug\InPutFileTask5V3.txt";
        private void buttonDone_CDV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_CDV.BackColor = Color.Red;
        }

        private void buttonDone_CDV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_CDV.BackColor = Color.Green;
        }

        private void buttonDone_CDV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_CDV.BackColor = Color.Blue;
        }

        private void buttonHelp_CDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНб-23-1 Чурин Дмитрий Владимирович", "Сообщение");
        }

        private void buttonDone_CDV_Click(object sender, EventArgs e)
        {
            dataGridViewNums_CDV.ColumnCount = 2;
            dataGridViewNums_CDV.Columns[0].Width = 20;
            dataGridViewNums_CDV.Columns[0].Width = 50;

            this.chartGraph.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraph.ChartAreas[0].AxisY.Title = "Ось Y";

            chartGraph.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length;i++)
            {
                dataGridViewNums_CDV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartGraph.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_CDV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
