using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint3.Task6.V10.Lib;
namespace Tyuiu.KochetovKO.Sprint3.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт 3 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №3                                                                       ");
            Console.WriteLine("Тема: Обработка целочисленной информации                                        ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №5                                                                      ");
            Console.WriteLine("Вариант №10                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                        ");
            Console.WriteLine("Напишите программу, которая ищет среди целых чисел,принадлежащих числовому      ");
            Console.WriteLine("отрезку [20, 32] сумму всех делителей больше 12                                 ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            int startValue = 20;
            int stopValue = 32;

            var res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(res);

        }
    }
}