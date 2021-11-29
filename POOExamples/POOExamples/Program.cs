using System;

namespace POOExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Creation. */
            Circle myCircle;
            /* Instance. */
            myCircle = new Circle();
            double area = myCircle.calculateArea(5);
            Console.WriteLine($"The area is: {area}");

            Circle myCircleTwo = new Circle();
            double areaTwo = myCircle.calculateArea(6);
            Console.WriteLine($"The second area is: {areaTwo}");
        }
    }

    class Circle
    {
        const double PI = 3.1416;
        public double calculateArea(int radius)
        {
            return PI * radius * radius;
        }
    }
}
