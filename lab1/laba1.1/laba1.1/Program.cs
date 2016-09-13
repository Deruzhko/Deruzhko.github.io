using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, u;

            Console.Write("Введите X:");
            x = double.Parse(Console.ReadLine());

            Console.Write("Введите Y:");
            y = double.Parse(Console.ReadLine());

            Console.Write("Введите Z:");
            z = double.Parse(Console.ReadLine());

            u = Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), (1.0 / 3.0)) / (x * x + y * y + 2) - Math.Exp(Math.Abs(x - y)) * Math.Pow((Math.Tan(z) + 1), x);
            Console.WriteLine("для x="+x+" y="+y+" z="+z);
            Console.WriteLine ("u = "+ u);

            x = -4.5;
            y = 0.75e-4;
            z = 0.845e2;

            u = Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), 1.0 / 3.0) / (x * x + y * y + 2) - Math.Exp(Math.Abs(x - y)) * Math.Pow((Math.Tan(z) + 1), x);
            Console.WriteLine("для значений из методички x=" + x + " y=" + y + " z=" + z);
            Console.WriteLine("u = " + u);

            Console.WriteLine("\n\nПрограмма завершена. Для выхода нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
