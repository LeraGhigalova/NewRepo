using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число k");
            var k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число m");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число n");
            var n = int.Parse(Console.ReadLine());

            if (IfLogicalExpressionTrue(k, m, n))
                Console.WriteLine("k, m, n - отрицательные числа");
            else
                Console.WriteLine("Хотя бы одно из чисел положительное");
            {
            }
        }
        static bool IfLogicalExpressionTrue(int k, int m, int n) =>
            (k < 0) && (m < 0) && (n < 0);
    }
}
