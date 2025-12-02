using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников");
            var n = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите зарплату {i + 1}-ого сотрудника");
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Общая сумма выплаченных денег = {sum}");
        }
    }
}
