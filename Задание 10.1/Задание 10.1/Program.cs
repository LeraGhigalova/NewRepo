using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double p0 = 1.29;
            const double C = 1.25e-4;

            Console.WriteLine("Введите число n от 10 до 100:");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n < 10 || n > 100)
            {
                Console.WriteLine("Ошибка ввода. n должно быть целым числом от 10 до 100");
                return;
            }

            Console.WriteLine("Высота  Плотность воздуха");

            for (int i = 0; i <= n; i++)
            {
                int h = i * 100;
                double p = p0 * Math.Exp(-C * h);
                Console.WriteLine($"{h,8}{p:F5}");
            }

        }
    }
}
