using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте найдем квадрат числа N!");
            Console.Write("Введите целое число больше 0: ");
            double N = Convert.ToDouble(Console.ReadLine());
            int i = 1;
            int NN = 0;
            if (N > 0 && Math.Floor(N) == N)
            {
                for (; i<=N; i++)
                {
                    NN = NN + (2*i-1);
                    Console.WriteLine("Квадрат числа {0} равен {1}", i, NN);
                }
            }
            else
            {
                Console.WriteLine("Введено неверное число!");

            }
            Console.WriteLine("Для завершения работы нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
