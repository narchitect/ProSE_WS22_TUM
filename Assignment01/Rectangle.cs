using System;

namespace Assignment
{
    class Rectangle : ImplicitGeometry
    {
        public double x1, x2, y1, y2;

        public Rectangle(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override bool IsInside(double x, double y)
        {
            return (x1 <= x) && (x <= x2) && (y1 <= y) && (y <= y2); 
        }       
    }
}