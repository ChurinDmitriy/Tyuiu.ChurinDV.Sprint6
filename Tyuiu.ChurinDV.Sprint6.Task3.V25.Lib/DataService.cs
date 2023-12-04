using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChurinDV.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;

            int[] array = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                array[i] = matrix[i, 2];
            }
            Array.Sort(array);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 2] = array[i];
            }
            return matrix;
        }
    }
}
