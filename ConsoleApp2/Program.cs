using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = double.Parse(Console.ReadLine());
            PrintAllValues(r);
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите x");
                    String user_input = Console.ReadLine();
                    if (user_input == "")//если ничего не ввели,заканчиваем программу
                    {
                        break;
                    }
                    double x = double.Parse(user_input);
                    WhatIsFunction(x, r);
                }
                catch (System.FormatException)//проверка на число
                {
                    Console.WriteLine("Введён некорректный x");
                }
            }
        }
       



        static double GetYFromFirstSegment(double x, double R)//первый сегмент
        {
            double y = -Math.Round(Math.Sqrt(R * R - (x + 8) * (x + 8)), 4);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static double GetYfromSecondSegment(double x)//второй сегмент
        {
            double y = 2;
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static double GetYFromThirdSegment(double x)//третий сегмент
        {
            double y = Math.Round((-(0.5) * x), 6);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static double GetYfromFourthSegment(double x)
        {
            double y = Math.Round((x - 3), 2);
            Console.WriteLine($"Значение функции при x = {x}: {y}");
            return y;
        }

        static void WhatIsFunction(double x, double r)
        {
            if (-10 <= x && x <= -6)
            {
                GetYFromFirstSegment(x, r);
            };
            if (-6 <= x && x <= -4)
            {

                GetYfromSecondSegment(x);
            };
            if (-4 <= x && x <= 2)
            {
                GetYFromThirdSegment(x);
            };
            if (2 < x && x <= 4)
            {
                GetYfromFourthSegment(x);
            };
            if (x > 4 || x < -10)
            {
                Console.WriteLine("x должен принадлежать отрезку [-10, 4]");
            };
        }

        static void PrintAllValues(double r)//выдача значений с шагом 0,2
        {
            for (double x = -10; x <= 4; x += (double)0.2)
            {
                WhatIsFunction(Math.Round(x, 2), r);
            }

        }
    }
}