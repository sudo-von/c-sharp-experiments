using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result from {numberOne} + {numberTwo} is {numberOne + numberTwo}");

        }
    }
}
