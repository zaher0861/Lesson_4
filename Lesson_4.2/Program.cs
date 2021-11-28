using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте введем несколько рандомных целых чисел, но последнее обязательно должно быть 0");
            Console.WriteLine("и сравним, что больше, количество положительных или количество отрицательных!");
            Console.WriteLine();
            int i;
            int N_minus = 0;
            int N_plus = 0;
            do
            {
                Console.Write("Введите целое число: ");
                i = Convert.ToInt32(Console.ReadLine());
                    if (i < 0)
                    {
                        N_minus++;
                    }
                    else
                    {
                        N_plus++;
                    }
            } while (i != 0);
            Console.WriteLine("Количество отрицательных чисел - {0}, положительных - {1}", N_minus, N_plus);
            Console.WriteLine("Для завершения работы нажмите любую клавишу");
            Console.ReadKey();


        }
    }
}
