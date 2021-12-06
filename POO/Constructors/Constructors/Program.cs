using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            Console.WriteLine($"First car's length: {firstCar.getLength()}");
            Console.WriteLine($"First car's width: {firstCar.getWidth()}");
            Car secondCar = new Car(4600.10,.1600);
            Console.WriteLine($"Second car's length: {secondCar.getLength()}");
            Console.WriteLine($"Second car's width: {secondCar.getWidth()}");
        }
    }

    class Car
    {
        private int wheels;
        private double length;
        private double width;
        public Car()
        {
            wheels = 4;
            length = 2300.5;
            width = 0.800;
        }
        public Car(double lengthCar, double widthCar)
        {
            wheels = 4;
            length = lengthCar;
            width = widthCar;
        }
        public double getLength()
        {
            return length;
        }
        public double getWidth()
        {
            return width;
        }
    }
}
