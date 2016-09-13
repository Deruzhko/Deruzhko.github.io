using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            EnterArray(a);
            PribtArray(a);

            int max = a[0]*a[0]*a[0];

            Console.WriteLine("Куб максимального элемента, до первого отрицатеьного равен:");
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i + 1] < 0 )
                {
                    if (a[i]*a[i]*a[i] > max)
                        max = a[i] * a[i] * a[i];
                    Console.WriteLine(max);
                    break;
                }
                if (a[i] > a[i + 1] && a[i]*a[i]*a[i] > max)
                     max = a[i] * a[i] * a[i];
                 else
                     if (a[i + 1]*a[i+1]*a[i+1] > max)
                        max = a[i] * a[i] * a[i];
                
            }

            Console.WriteLine("\n\nПрограмма завершена. Для выхода нажмите любую клавишу");
            Console.ReadKey();

        }
        public static void EnterArray(Array a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write("Введите {0} элемент массива: ", i + 1);
                a.SetValue(Convert.ToInt32(Console.ReadLine()), i);
            }
            Console.WriteLine("******************************************");
        }
        public static void PribtArray(Array a)
        {
            Console.WriteLine("Для массива: ");
            foreach (object x in a)
                Console.Write(" " + x);
            Console.WriteLine();
        }

    }
}
