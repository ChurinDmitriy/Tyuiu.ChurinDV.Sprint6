using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChurinDV.Sprint6.Task0.V23.Lib
{
    public class DataService : ISprint6Task0V23
    {
        public double Calculate(int x)
        {
            double x1 = x + 1;
            double x2 = x + 2;
            double drob = x1 / x2;
            double res = Math.Log(drob);
            return Math.Round(res, 3);
        }
    }
}
