using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число: ");
            var x = double.Parse(Console.ReadLine());
            var y = F(x);

            Console.WriteLine("Y = " + y);
        }
        static double F(double x) => (2.0 / (x * x + 25) + Math.Cos(x)) / (Math.Sqrt(Math.Pow(x, 4) + 1) + (Math.Sin(x) + Math.Cos(x)) / 2.0);
    }
}
