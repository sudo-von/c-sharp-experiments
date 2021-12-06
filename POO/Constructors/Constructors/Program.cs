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
            Console.WriteLine(secondCar.getExtras());
            secondCar.setExtras(true, "leather");
            Console.WriteLine(secondCar.getExtras());
        }
    }

    class Car
    {
        private int wheels;
        private double length;
        private double width;
        private bool airConditioner;
        private string tapestry;
        public Car()
        {
            wheels = 4;
            length = 2300.5;
            width = 0.800;
        }
        public Car(double lengthCar, double width)
        {
            wheels = 4;
            length = lengthCar;
            this.width = width;
        }
        public double getLength()
        {
            return length;
        }
        public double getWidth()
        {
            return width;
        }
        public void setExtras(bool carAirConditioner, string carTapestry)
        {
            airConditioner = carAirConditioner;
            tapestry = carTapestry;
        }
        public string getExtras()
        {
            return $"Extras:\ntapestry: {tapestry}\nair conditioner: {airConditioner}";
        }
    }
}
