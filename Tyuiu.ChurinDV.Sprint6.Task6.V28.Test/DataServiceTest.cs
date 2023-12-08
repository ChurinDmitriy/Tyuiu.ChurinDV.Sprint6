using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ChurinDV.Sprint6.Task6.V28.Lib;

namespace Tyuiu.ChurinDV.Sprint6.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            string path = @"C:\Users\Ghostxr\source\repos\Tyuiu.ChurinDV.Sprint6\Tyuiu.ChurinDV.Sprint6.Task6.V28\bin\Debug\InPutFileTask6V28.txt";
            DataService ds = new DataService();

            string res = ds.CollectTextFromFile(path);
            string wait = "wFrlYaZtHI l eAezSXF eqSGAiC wUdVEuNB";
            Assert.AreEqual(wait, res);
        }
    }
}
