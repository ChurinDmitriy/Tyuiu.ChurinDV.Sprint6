using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChurinDV.Sprint6.Task2.V10.Lib;

namespace Tyuiu.ChurinDV.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

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
            MessageBox.Show("Таск 2 выполнил студент группы ИСТНб-23-1 Чурин Дмитрий Владимирович", "Сообщение");
        }

        private void buttonDone_CDV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStartStep_CDV.Text);
                int stopStep = Convert.ToInt32(textBoxVarStopStep_CDV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_CDV.Titles.Add("График функции 2x - 4 + (2x - 1 / sin(x) + 1)");

                this.chartFunction_CDV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_CDV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_CDV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_CDV.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
