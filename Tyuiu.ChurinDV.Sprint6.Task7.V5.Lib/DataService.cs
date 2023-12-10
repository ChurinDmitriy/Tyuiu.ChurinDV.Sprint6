using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ChurinDV.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
            int rows;
            int colums;

            string fileData = File.ReadAllText(path);

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

            int[,] ResArrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    if ((c == colums -1) && (arrayValues[r, c] < 2))
                    {
                        ResArrayValues[r, c] = 2;
                    }
                    else
                    {
                        ResArrayValues[r, c] = arrayValues[r, c];
                    }
                }
            }
            return ResArrayValues;
        }
    }
}
