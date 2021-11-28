using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            printUntilGivenNumber(10);
            Console.WriteLine(sumTwoNumbers(1,2));
            Console.WriteLine(divideTwoNumbers(2, 1));
        }

        static void printUntilGivenNumber(int number)
        {
            Console.WriteLine("Starting...");
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished...");
        }

        static int sumTwoNumbers(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        static int divideTwoNumbers(int numberOne, int numberTwo) => numberOne / numberTwo;
    }
}
