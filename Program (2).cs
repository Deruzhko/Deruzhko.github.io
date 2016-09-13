using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2._3
{
    public struct Spisok
    {
        //поля структуры
        public int ball;
        public string name;
        public int doxod;
        public int gruppa;

        // метод структуры (перегруженный)
        public override string ToString()
        {
            return (string.Format("Имя студента {0}; ball {1} ; Группа № {2};Размер дохода на одного члена семьи: {3}", name, ball, gruppa, doxod));
        }//конец метода
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество нуждающихся в общежитии:");
            int n = Convert.ToInt32(Console.ReadLine());
            Spisok[] nz = new Spisok[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("{0} Нуждаюшиийся:", i + 1);
                Console.WriteLine("Имя:");
                nz[i].name = Console.ReadLine();
                Console.WriteLine("Номер группы:");
                nz[i].gruppa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Доход:");
                nz[i].doxod = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Средний балл:");
                nz[i].ball = Convert.ToInt32(Console.ReadLine());
                


            }

            Console.WriteLine("");
            Console.WriteLine("Введите количество мест в общежитии:");

            
            int m = Convert.ToInt32(Console.ReadLine());
            int mrot = 400;
            int count = 0;

            for (int i = 0; i < nz.Length; i++)
            {
                for (int j = 0; j < nz.Length - i - 1; j++)
                {
                    if (nz[j].ball < nz[j+1].ball)
                    {
                        Spisok temp= nz[j];
                        nz[j].ball = nz[j + 1].ball;
                        nz[j + 1].ball = temp.ball;
                    }
                }
            }


            for (int i = 0; i < n; i++)
            {
                if (nz[i].doxod <= mrot && count < m)
                {
                    Console.WriteLine("{0} - Выдана комната!", nz[i]);
                    count++;
                }
                if (count == m) {
                    Console.WriteLine("комнаты закончились");
                    break;
                }
            }

            if(count < m)
            {
                Console.WriteLine("льготники закончились, дальше по среднему балу");
                for (int i = 0; i < n; i++)
                {
                    if(count < m && nz[i].doxod > mrot)
                    {
                        Console.WriteLine("{0} - Выдана комната!", nz[i]);
                        count++;
                    }
                    if(count == m)
                    {
                        Console.WriteLine("комнаты закончились");
                        break;
                    }
                }
            }

            Console.WriteLine("\n\nПрограмма завершена. Для выхода нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
