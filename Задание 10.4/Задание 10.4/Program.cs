using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел, оканчивающуюся нулём:");
            int number;
            int countEven = 0;

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number != 0 && number % 2 == 0)
                {
                    countEven++;
                }
            }
            while (number != 0);

            Console.WriteLine($"Количество чётных чисел в последовательности: {countEven}");
            
        }
    }
}
