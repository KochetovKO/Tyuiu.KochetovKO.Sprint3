using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KochetovKO.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task2V19
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double series = 0;
            int i = startValue;
            do
            {
                series = series + (Math.Cos(i) * 0.5);
                i++;
            
            } while (i <= stopValue);
            return Math.Round(series, 3);
        }
    }
}
