using System;

namespace Assignment
{
    class Ring
    {
        //create properties of circle inside and outside (data type이 무엇인가?)
        public Circle OuterCircle {get; set;}
        public Circle InnerCircle {get; set;}

        public Ring(Circle outerCircle, Circle innerCircle)
        {
            OuterCircle = outerCircle;
            InnerCircle = innerCircle;
        }

        public bool InsideOfRing(double x, double y)
        {
            bool insidOuter = OuterCircle.InsideOfCircle(x,y);
            // boolean 타입에 !를 붙이면 반대값.
            bool outsideInner = !InnerCircle.InsideOfCircle(x,y);
            // if (True & True) = return Ture / || or
            return insidOuter && outsideInner;
        }

    }
}