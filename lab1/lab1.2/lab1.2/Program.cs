using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
           double x, a, b;

            Console.Write("Введите a:");
            a = double.Parse(Console.ReadLine());

            Console.Write("Введите b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("при a=" + a + " b=" + b);
            
            if(Math.Abs(a-b)<1e-10)
            {
                x = -5;
                Console.WriteLine("X = " + x);
            } 
            else if (a > b)
            {
                x = b / a + 61;
                Console.WriteLine("X = " + x);
            }
            else
            {
                x = (b - a) / b;
                Console.WriteLine("X = " + x);
            }

            Console.WriteLine("\n\nПрограмма завершена. Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
