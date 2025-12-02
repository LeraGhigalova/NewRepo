using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите k от 2 до 10 включительно:");
            int k = int.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("a должно быть меньше b");
                return;
            }

            if (k < 2 || k > 10)
            {
                Console.WriteLine("k должно быть в диапазоне от 2 до 10");
                return;
            }
            for (int num = a; num <= b; num ++)
            {
                int SumDivisors = 0;
                for (int div = 1; div < num; div++)
                {
                    if (num % div == 0)
                    {
                        SumDivisors += div;
                    }
                }
                if (SumDivisors % k == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
