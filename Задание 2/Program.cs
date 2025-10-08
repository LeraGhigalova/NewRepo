using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первого катета: ");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета: ");
            var b = double.Parse(Console.ReadLine());

            var S = (a + b) / 2;
            var c = Math.Sqrt(a * a + b * b);
            var P = a + b + c;

            Console.WriteLine("Площадь прямоугольного треугольника равна " + S);
            Console.WriteLine("Периметр прямоугольного треугольника равен " + (int)Math.Round(P));        }
    }
}
