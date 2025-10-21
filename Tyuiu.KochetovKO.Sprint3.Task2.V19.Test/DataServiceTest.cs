using Tyuiu.KochetovKO.Sprint3.Task2.V19.Lib;
namespace Tyuiu.KochetovKO.Sprint3.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;

            double wait = 0.291;

            double res = ds.GetSumSeries(startValue, stopValue);

            Assert.AreEqual(wait, res);

        }
    }
}
