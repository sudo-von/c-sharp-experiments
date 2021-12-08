using System;
using static System.Math;
using static System.Console;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Check to do list.
            //doWork();
            double root = Sqrt(9);
            double pow = Pow(3, 4);
            WriteLine($"root: {root}");
            WriteLine($"pow: {pow}");
            // --------- anonymous class --------------
            var myVar = new { Name = "VoN", Age = 24 };
            Console.WriteLine($"Name: {myVar.Name} - Age: {myVar.Age}");
            // They belong to the same anonymous class.
            var anotherVar = new { Name = "Sudo", Age = 25 };
            Console.WriteLine($"Name: {anotherVar.Name} - Age: {anotherVar.Age}");
            myVar = anotherVar;
            Console.WriteLine($"Name: {myVar.Name} - Age: {myVar.Age}");
            /*
             * Only contains public fields.
             * All fields must be initialized.
             * Fields can't be static.
             * Cant' define methods.
             */
        }

        static void doWork()
        {
            Dot origin = new Dot();
            Dot destination = new Dot(10,20);
            double distance = origin.getDistance(destination);
            Console.WriteLine($"Distance: {distance}");
            Console.WriteLine($"Total instances: {Dot.getObjectCounter()}");
            Console.WriteLine(Dot.constantTest);
        }
    }
}
