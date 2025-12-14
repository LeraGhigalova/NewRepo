using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            bool isAscending = true;

            for (int j = 0; j < cols; j++)
            {
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] <= matrix[i - 1, j])
                    {
                        Console.WriteLine($"Нарушение порядка между элементами: [{i - 1},{j}] = {matrix[i - 1, j]} и [{i},{j}] = {matrix[i, j]}");
                        isAscending = false;
                    }
                }
            }

            if (isAscending)
                Console.WriteLine("Все столбцы упорядочены по возрастанию.");
            else
                Console.WriteLine("Порядок возрастания в столбцах нарушен.");

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                int sumEven = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        sumEven += matrix[i, j];
                }
                Console.WriteLine($"Строка {i}: сумма чётных элементов = {sumEven}");
            }
        }
    }
}
