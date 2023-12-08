using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ChurinDV.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public int lenResultArray = 0;
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        len++;
                    }
                }
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        lenResultArray++;
                    }
                }
            }

            double[] resultArray = new double[lenResultArray];

            int index = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(","))
                    {
                        resultArray[index] = Convert.ToDouble(line);
                        index++;
                    }
                }
            }
            return resultArray;
        }
    }
}
