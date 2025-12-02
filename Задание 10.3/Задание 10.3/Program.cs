using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");

            var n = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 1;
            int sum = 1;
            int current = 1;

            while (current + b <= n)
            {
                current = a + b;
                sum += current;
                a = b;
                b = current;
            }

            Console.WriteLine($"Сумма чисел Фибоначчи, не превосходящих {n} равна {sum}");
        }
    }
}
