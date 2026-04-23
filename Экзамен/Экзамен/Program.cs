using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзамен
{
    internal class Program
    {
        static bool ContainsThreeConsecutiveOnes(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    count++;
                    if (count == 3) return true;
                }
                else
                {
                    count = 0;
                }
                n >>= 1;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int N = 1000;
            long sum = 0;

            for (int n = 1; n <= N; n++)
            {
                if (n % 2 == 1 && ! ContainsThreeConsecutiveOnes(n))
                {
                    sum += (long)n * n;
                }
            }
            Console.WriteLine($"F({N}) = {sum}");
        }
    }
}
