using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static int Sum(params int[] numbers)
        {
            int result = 0;
            foreach (int n in numbers)
                result += n;
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(1, 2, 3));        
            Console.WriteLine(Sum(10, 20));         
            Console.WriteLine(Sum());               
            Console.WriteLine(Sum(5, 10, 15, 20)); 
        }
    }
}
