using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KochetovKO.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiValue = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                multiValue *= Math.Cos(0.1) + (1.0 / (k * k));
                k++;
            }

            return Math.Round(multiValue, 3);
        }  
    }
}
