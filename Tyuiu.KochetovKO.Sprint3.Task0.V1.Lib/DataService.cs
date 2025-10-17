using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KochetovKO.Sprint3.Task0.V1.Lib
{
    public class DataService : ISprint3Task0V1
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            
            double SumSeries = 0;
            int i = 0; 
            for (i = startValue; i <= stopValue; i++) 
            {
                SumSeries = (value * value * i) + 1;
            }
            return Math.Round(SumSeries, 3);
        }
    }
}
