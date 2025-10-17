using Tyuiu.KochetovKO.Sprint3.Task0.V1.Lib;
using System.Security.Cryptography.X509Certificates;

namespace Tyuiu.KochetovKO.Sprint3.Task0.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int stopValue = 15;
            int startValue = 1;
            int value = 4;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 241;
            Assert.AreEqual(wait, res);
        }
    }
}
