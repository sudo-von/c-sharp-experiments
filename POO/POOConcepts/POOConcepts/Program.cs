using System;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Check to do list.
            doWork();
        }

        static void doWork()
        {
            Dot origin = new Dot();
            Dot destination = new Dot(10,20);
            double distance = origin.getDistance(destination);
            Console.WriteLine(distance);
        }
    }
}
