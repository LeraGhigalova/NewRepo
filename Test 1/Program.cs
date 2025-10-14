using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Александр Блок");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ночь, улица, фонарь, аптека");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ночь, улица, фонарь, аптека,");
            Console.WriteLine("Бессмысленный и тусклый свет.");
            Console.WriteLine("Живи ещё хоть четверть века -");
            Console.WriteLine("Всё будет так. Исхода нет.");

            Console.ResetColor();

        }
    }
}
