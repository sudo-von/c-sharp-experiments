using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            switch (number)
            {
                case 1:
                    Console.WriteLine("Your number is 1");
                    break;
                case 2:
                    Console.WriteLine("Your number is 2");
                    break;
                case 3:
                    Console.WriteLine("Your number is 3");
                    break;
                default:
                    Console.WriteLine("Your number is bigger than 3");
                    break;
            }
        }
    }
}
