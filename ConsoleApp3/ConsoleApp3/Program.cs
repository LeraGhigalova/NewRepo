using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Greet(string name, bool isFormal = false)
        {
            if (isFormal)
                Console.WriteLine($"Здравствуйте, {name}!");
            else
                Console.WriteLine($"Привет, {name}!");
        }
        static void Main(string[] args)
        {          
            Greet("Анна", true);
            Greet("Иван");
        }
    }
}
