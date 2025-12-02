using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите целое число n (n ≤ 20): ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 20)
            {
                Console.WriteLine("Ошибка: n должно быть от 1 до 20");
                return;
            }

            Console.Write("Введите действительное число λ: ");
            double lambda = double.Parse(Console.ReadLine());

            double[] arr = new double[n];
            double eMinusLambda = Math.Exp(-lambda);

            for (int i = 0; i < n; i++)
            {
                arr[i] = Math.Pow(lambda, i) / Factorial(i) * eMinusLambda;
            }

            Console.WriteLine("Массив последовательности:");
            PrintArray(arr);

            ReplaceWithCumulativeSum(arr);
            Console.WriteLine("Кумулятивная сумма элементов:");
            PrintArray(arr);

            double sumDiff = SumOfAbsoluteDifferences(arr);
            Console.WriteLine($"Сумма модулей разностей соседних элементов: {sumDiff:F3}");

            double[] diffArr = DifferencesArray(arr, lambda);
            Console.WriteLine("Массив разностей элементов и λ:");
            PrintArray(diffArr);
            }
            private static long Factorial(int x)
            {
                long fact = 1;
                for (int i = 2; i <= x; i++) fact *= i;
                return fact;
            }

            static void PrintArray(double[] arr)
            {
                foreach (var val in arr)
                    Console.Write($"{val:F3} ");
                Console.WriteLine();
            }

            static void ReplaceWithCumulativeSum(double[] arr)
            {
                for (int i = 1; i < arr.Length; i++)
                    arr[i] += arr[i - 1];
            }

            static double SumOfAbsoluteDifferences(double[] arr)
            {
                double sum = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                    sum += Math.Abs(arr[i + 1] - arr[i]);
                return sum;
            }

            static double[] DifferencesArray(double[] arr, double a)
            {
                double[] diff = new double[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                    diff[i] = arr[i] - a;
                return diff;
            }
        }
    }