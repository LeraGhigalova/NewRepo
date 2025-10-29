using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine($"f({x:F2}) = {F(x):F2}");
        }

        static double F(double x)
        {
            if (x > -(Math.PI) / 2 && x < Math.PI / 2)
                return Math.Tan(x);
            else if (x >= Math.PI / 2)
                return 1 / x;
            else
                return -1 / x;
        }
    }
}
