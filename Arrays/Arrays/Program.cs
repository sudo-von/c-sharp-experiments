using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages;
            ages = new int[4];
            ages[0] = 10;
            ages[1] = 20;
            ages[2] = 30;
            Console.WriteLine($"0: {ages[0]} 1: {ages[1]} 2: {ages[2]} 3: {ages[3]}");

            int[] newAges = { 10, 20, 30 };
            Console.WriteLine($"0: {newAges[0]} 1: {newAges[1]} 2: {newAges[2]}");

            int[] oldAges = new int[4]{ 10, 20, 30, 40 };
            Console.WriteLine($"0: {oldAges[0]} 1: {oldAges[1]} 2: {oldAges[2]} 3: {oldAges[3]}");

        }
    }
}
