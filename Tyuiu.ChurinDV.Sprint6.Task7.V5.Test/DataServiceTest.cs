using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChurinDV.Sprint6.Task7.V5.Lib;


namespace Tyuiu.ChurinDV.Sprint6.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint6\Tyuiu.ChurinDV.Sprint6.Task7.V5\bin\Debug\InPutFileTask7V5.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] wait = { { 15, 3, -4, -12, -2, 11, 10, -4, -17, 5 },
                { 11, -10, -3, -9, 9, 16, -2, 4, 15, 1 },
                { -4, -14, 11, -8, -3, -19, -13, 12, -13, -11},
                { 18, 4, -5, 16, -17, -2, -6, 2, -17, 17 },
                { -18, -12, -10, 20, 12, -15, -7, -9, 18, 14},
                {-6, -4, -11, -3, -7, -19, -1, 1, 20, -15 },
                { -11, -19, -16, 1, 1, 19, 9, 1, -18, -19},
                { -13, -2, -19, 3, 0, 0, -20, -20, -1, -6},
                { 0, -20, -16, 16, 1, -14, 18, -3, 5, 12},
                { 18, -14, 0, 6, -7, 5, -14, -9, 16, -8} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
