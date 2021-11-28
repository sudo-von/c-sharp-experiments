using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(1,2));
            Console.WriteLine(sum(1,2,3));
            Console.WriteLine(sum(1,2,3,4));
        }

        static int sum(int num1, int num2) => num1 + num2;
        static int sum(int num1, int num2, int num3) => num1 + num2 + num3;
        static int sum(int num1, int num2, int num3, int num4) => num1 + num2 + num3 + num4;
    }
}
