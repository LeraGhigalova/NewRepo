using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трёхзначное число: ");
            var a = int.Parse(Console.ReadLine());

            var b = a / 10;
            var c = a % 10;

            Console.WriteLine("Полученное число: " + c + b);
        }
    }
}
