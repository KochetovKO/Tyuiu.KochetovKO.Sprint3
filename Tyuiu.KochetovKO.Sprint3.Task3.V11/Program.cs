using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint3.Task3.V11.Lib;
namespace Tyuiu.KochetovKO.Sprint3.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 3 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №3                                                                       ");
            Console.WriteLine("Тема: Оператор цикла foreach                                                      ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №3                                                                      ");
            Console.WriteLine("Вариант №11                                                                      ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                        ");
            Console.WriteLine("Написать программу используя цикл do...while,                                   ");
            Console.WriteLine("которая вычисляет произведение ряда по формуле                                  ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            string value = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';

            var res = ds.ReplaceCharOnNum(value, replaceable, replacement);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(res);




        }
    }
}