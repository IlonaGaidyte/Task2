using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string inputB = Console.ReadLine();

            int result = int.Parse(inputA) + int.Parse(inputB);
            Console.WriteLine($"Sum is: {result}"); // “result” is variable name;

        }
    }
}
