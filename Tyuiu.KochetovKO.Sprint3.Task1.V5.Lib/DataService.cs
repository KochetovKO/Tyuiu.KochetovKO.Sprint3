using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KochetovKO.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiValue = 1;
            while (startValue <= stopValue)
            {
                multiValue = multiValue + Math.Cos(0.1) + Math.Pow(startValue, -2);
                startValue++;
            }
            return Math.Round(multiValue, 3);
        }  
    }
}
