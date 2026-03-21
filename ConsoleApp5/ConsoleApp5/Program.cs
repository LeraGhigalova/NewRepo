using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int result = Sum(3, 5); 
            Console.WriteLine(result);
        }
    }
}
