using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KochetovKO.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiValue = 1;
            double x = 0.1;
            while (startValue <= stopValue)
            {
                multiValue = multiValue + Math.Cos(x) + Math.Pow(startValue, -2);
            
            }
            return Math.Round(multiValue, 3);
        }  
    }
}
