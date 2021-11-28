using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Explicit */
            double temperature = 35.0;
            int temperature2 = (int)temperature;
            /* 
             * Implicit 
             * https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/numeric-conversions
             */
            int people = 10000;
            long people2 = people;
            float weight = 5.78F;
            double weight2 = weight;
        }
    }
}
