using System;
using System.Collections.Generic;
using System.Text;

namespace POOConcepts
{
    class Dot
    {
        public Dot()
        {
            Console.WriteLine("Default constructor...");
        }
        public Dot(int x, int y)
        {
            Console.WriteLine($"x: {x}\ny: {y}");
        }
    }
}
