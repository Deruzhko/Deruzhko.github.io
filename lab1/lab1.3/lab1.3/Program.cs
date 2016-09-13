using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._3
{
    class Program
    {
        static void Main()
        {
            const double epx = 0.001, dx = 0.1, xmin = -1, xmax = 1;
            const string funcname = "Ln(x+1)";
            int iters;
            Console.WriteLine("Рассчет функции: {0}\nС точностью {1} и шагом {2}\nВ диапазоне [{3},{4}]\n\n", funcname, epx, dx, xmin, xmax);
            Console.WriteLine("x\tЗначение по тейлору\t\tТочное значение\t\t\tСлагаемых");
            for (double x = xmin; x < xmax; x += dx)
                Console.WriteLine("{0,-7}{1,-25}\t{2,-25}\t{3}", x, F(x, epx, out iters), Math.Log(x + 1), iters);
            Console.WriteLine("\n\nПрограмма завершена. Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }


        private static double F(double x, double eps, out int i)
        {
            i = 0;
            if (Math.Abs(x - 0) < double.Epsilon) return 0;
            double result = 0, lastresult = double.MinValue, multipler = x;
            do
            {
                lastresult = result;
                result += multipler / ++i;
                multipler *= -x;
            } while (Math.Abs(result - lastresult) >= eps);
            return result;
        }
    }
}
