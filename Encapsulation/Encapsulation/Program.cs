using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ConverterEuroDollar conv = new ConverterEuroDollar();
            Console.WriteLine(conv.convert(50));
            /* conv.euro = 1.45; */
            conv.changeEuroValue(1.45);
            Console.WriteLine(conv.convert(50));
        }
    }

    class ConverterEuroDollar
    {
        private double euro = 1.253;

        public double convert(double quantity)
        {
            return quantity * euro;
        }

        public void changeEuroValue(double newValue)
        {
            if (newValue > 0)
            {
                euro = newValue;
            }
        }
    }

}
