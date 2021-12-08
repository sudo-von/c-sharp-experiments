using System;
using System.Collections.Generic;
using System.Text;

namespace POOConcepts
{
    class Dot
    {
        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
            objectCounter++;
        }
        public Dot()
        {
            this.x = 0;
            this.y = 0;
            objectCounter++;
        }

        public double getDistance(Dot anotherDot)
        {
            int xDif = this.x - anotherDot.x;
            int yDif = this.y - anotherDot.y;
            double distance = Math.Sqrt(Math.Pow(xDif,2) + Math.Pow(yDif,2));
            return distance;
        }

        public static int getObjectCounter() => objectCounter;

        private int x, y;
        private static int objectCounter = 0;
        public const int constantTest = 7;
    }
}
