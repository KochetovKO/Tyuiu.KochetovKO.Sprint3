using Tyuiu.KochetovKO.Sprint3.Task4.V29.Lib;

namespace Tyuiu.KochetovKO.Sprint3.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double wait = 0.291;

            double res = ds.Calculate(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}