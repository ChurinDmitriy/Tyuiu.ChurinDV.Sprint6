using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint6.Task5.V3.Lib;

namespace Tyuiu.ChurinDV.Sprint6.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint6\Tyuiu.ChurinDV.Sprint6.Task5.V3\bin\Debug\InPutFileTask5V3.txt";
            DataService ds = new DataService();

            double[] valueWaitArray = new double[5];

            valueWaitArray[0] = 2.5;
            valueWaitArray[1] = -2.6;
            valueWaitArray[2] = 5.7;
            valueWaitArray[3] = -6.8;
            valueWaitArray[4] = 9.9;

            double[] res;
            res = new double[5];
            res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
