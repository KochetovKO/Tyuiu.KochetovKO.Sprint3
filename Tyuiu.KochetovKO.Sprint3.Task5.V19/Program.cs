using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint3.Task5.V19.Lib;
namespace Tyuiu.KochetovKO.Sprint3.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 3 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №3                                                                       ");
            Console.WriteLine("Тема: Использование операторов continue и break в циклах                        ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №5                                                                      ");
            Console.WriteLine("Вариант №19                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 6;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(res);
        }
    }
}