using System;

namespace Assignment
{
    class Circle
    {
        public static double radius { get; set; }
        public static bool InsideOfCircle (double x, double y) {
            return Math.Sqrt(x*x + y*y) <= radius;
        }
    }  
}