using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            long number = long.Parse(Console.ReadLine());

            int sign = 1;
            int result = 0;

            while (number > 0)
            {
                int digit = (int)(number % 10);
                result += sign * digit;
                sign = -sign;
                number /= 10;
            }

            Console.WriteLine($"Знакочередующая сумма цифр: {result}");
        }
    }
}
