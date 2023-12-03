using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChurinDV.Sprint6.Task0.V23.Lib;

namespace Tyuiu.ChurinDV.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonVopros_CDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСТНб-23-1 Чурин Дмитрий Владимирович", "Сообщение");
        }

        private void buttonDone_CDV_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                int x = Convert.ToInt32(textBoxVarX_CDV.Text);
                double res = ds.Calculate(x);

                textBoxResult_CDV.Text = Convert.ToString(res);
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
