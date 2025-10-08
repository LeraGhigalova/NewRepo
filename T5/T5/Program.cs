using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate(2, 3) + Calculate(7, 8) + Calculate(1, 4);
            Console.WriteLine(x);
        }

        static double Calculate(double a, double b) =>
            (a + Math.Tan(b)) / (a * a + b * b);
    }
}
