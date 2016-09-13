using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 8;
            int[,] a = new int[n, n]
            {
                {1,2,3,4,5,6,7,8},
                {2,2,3,9,5,6,8,1},
                {3,3,3,3,5,6,7,8},
                {4,3,3,-3,5,7,8,1},
                {5,3,5,0,3,6,9,9},
                {6,3,6,3,1,5,9,9},
                {7,3,7,-10,11,20,9,8},
                {8,3,8,9,3,6,7,8}
            };

            PrintArray(a);
            Console.WriteLine("K равны:");
            for (int i = 0; i < n; i++)
            {
                bool doesMatch = true;
                for (int j = 0; j < n; j++)
                    if (a[i, j] != a[j, i])
                        doesMatch = false;
                if (doesMatch)
                   Console.Write(" "+(i+1));
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {//ищем строки с отрицательными элементами и считаем суммы
                bool hasNegativeItem = false;
                for (int j = 0; j < n; j++)
                    if (a[i, j] < 0)
                        hasNegativeItem = true;
                if (hasNegativeItem)
                {
                    double sum = 0;
                    for (int j = 0; j < n; j++)
                        sum += a[i, j];
                    Console.WriteLine("Сумма строки {0} равна {1}", i+1, sum);
                }
            }
            Console.WriteLine("\n\nПрограмма завершена. Для выхода нажмите любую клавишу");
            Console.ReadKey();
            

        }
        public static void PrintArray(int[,] a)
        {
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write("\t" + a[i, j]);
                Console.WriteLine();
            }

        }
    }
            
}
