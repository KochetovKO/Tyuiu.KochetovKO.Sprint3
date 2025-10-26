using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint3.Task7.V17.Lib;
namespace Tyuiu.KochetovKO.Sprint3.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт 3 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №3                                                                       ");
            Console.WriteLine("Тема: Добавление к решению итоговых проектов                                    ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №7                                                                      ");
            Console.WriteLine("Вариант №17                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len]; 
            
            valueArray = ds.GetMassFunction(startValue,stopValue);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("+---------+----------+");
            Console.WriteLine("|     X   |    F(x)  |");
            Console.WriteLine("+---------+----------+");

            for (int i = 0; i <= len - 1; i++)
            {

                Console.WriteLine("|{0,5:d}       |         {1, 6:f2}   |", startValue, valueArray[i]);
                startValue++;

            }
            Console.WriteLine("+---------+----------+");













        }
    }
}