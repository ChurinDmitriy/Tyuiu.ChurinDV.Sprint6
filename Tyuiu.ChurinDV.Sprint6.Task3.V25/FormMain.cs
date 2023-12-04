using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChurinDV.Sprint6.Task3.V25.Lib;


namespace Tyuiu.ChurinDV.Sprint6.Task3.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { { 14, 5, -9, 18, 21 }, { -5, -12, -12, 4, 28 }, { 27, -2, -14, 23, 27 }, { -19, -15, 17, 15, 1 }, { 33, 2, 6, 24, 24 } };
        int[,] res = new int[5, 5] { { 14, 5, -14, 18, 21 }, { -5, -12, -12, 4, 28 }, { 27, -2, -9, 23, 27 }, { -19, -15, 6, 15, 1 }, { 33, 2, 17, 24, 24 } };

        private void buttonDone_CDV_Click(object sender, EventArgs e)
        {
            int rows = res.GetUpperBound(0) + 1;
            int colums = res.Length / rows;

            dataGridViewMatrix.ColumnCount = colums;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_CDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-23-1 Чурин Дмитрий Владимирович", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            dataGridViewMatrix.ColumnCount = colums;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
