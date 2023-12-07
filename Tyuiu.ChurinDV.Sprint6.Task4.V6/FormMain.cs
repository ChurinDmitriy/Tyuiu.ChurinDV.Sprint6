using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChurinDV.Sprint6.Task4.V6.Lib;
using System.IO;


namespace Tyuiu.ChurinDV.Sprint6.Task4.V6
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

                this.chartFunction_CDV.Titles.Add("График функции F(x) = 3cos(x) / 4x - 0,5 + sin(x) - 5x - 2");

                this.chartFunction_CDV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_CDV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutputData_CDV.Text = "";

                chartFunction_CDV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1;i++)
                {
                    this.chartFunction_CDV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutputData_CDV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНб-23-1 Чурин Дмитрий Владимирович", "Сообщение");
        }

        private void buttonSave_CDV_Click(object sender, EventArgs e)
        {
            try
            {

                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOutputData_CDV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\nОткрыть его можно в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
