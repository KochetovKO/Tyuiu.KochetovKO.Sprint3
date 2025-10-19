using Tyuiu.KochetovKO.Sprint3.Task1.V5.Lib;
namespace Tyuiu.KochetovKO.Sprint3.Task1.V5.Test
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
            
            double wait = 11.95;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
