using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Not allowed: const int NUMBER; */
            const int NUMBER = 50;
            Console.WriteLine($"Constant's value is: {NUMBER}");
        }
    }
}
