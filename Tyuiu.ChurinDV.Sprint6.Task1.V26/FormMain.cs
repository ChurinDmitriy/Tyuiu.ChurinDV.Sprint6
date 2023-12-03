using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChurinDV.Sprint6.Task1.V26.Lib;

namespace Tyuiu.ChurinDV.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_CDV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_CDV.Text);
                int stopStep = Convert.ToInt32(textBoxVarStop_CDV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_CDV.Text = "";
                textBoxResult_CDV.AppendText("+------------+-----------+" + Environment.NewLine);
                textBoxResult_CDV.AppendText("|      X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_CDV.AppendText("+------------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,7:d}     |  {1,6:f2}   | ", startStep, valueArray[i]);
                    textBoxResult_CDV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_CDV.AppendText("+------------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНб-23-1 Чурин Дмитрий Владимирович", "Сообщение");
        }
    }
}
