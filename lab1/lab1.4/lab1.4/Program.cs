using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._4
{
    class Program
    {
        static double min(double a, double b)
        {
            return (a < b) ? a : b;
        }

        static void Main(string[] args)
        {
            double a, b, u,v,c;
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());

            u = min(a,b);
            v = min(a * b, a + b);
            c = min(u + v * v, 3.14);
            Console.WriteLine("min(a,b): " + u + "  min(a * b, a + b): "+ v + "  min(u + v * v, 3.14): " + c);
            Console.WriteLine("\n\nПрограмма завершена. Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
