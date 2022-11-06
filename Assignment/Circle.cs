using System;

namespace Assignment
{
    class Circle : ImplicitGeometry
    {
        
        // //Declare a field "radius" in the class
        // private int radius;
    
        // //craete a Get Method.
        // //@그러면 메소드에 아무것도 파라미터를 넣지 않게 되면????
        // //overloading 
        // public int GetRadius()
        // {
        //     return radius;
        // }

        // public void SetRadius(int _radius)
        // {
        //     radius = _radius;
        // }

        //create a property(Method)
        // public int Radius //Property is a method written above, so it need to be UpperLetter.
        // //하지만 분명하게 method는 아니다. 왜냐하면 assigment 되는 형식으로 set이 호출되고, value처럼 get이 호출.
        // {
        //     get {return radius;}
        //     set {radius = value; }
        // }

        //Short version of above property
        //Cmplier automatically create a "private" field called "radius".
        public double Radius {get; set;} 
        public double X {get; set;}
        public double Y {get; set;}
        public Circle (double radius, double x, double y) {
            this.Radius = radius;
            this.X = x;
            this.Y = y; 
        }
        public bool InsideOfCircle (double x, double y) {
            return Math.Sqrt(x*x + y*y) <= Radius;
        }

        //IsInside 함수를 호출할때 이미 Circle 인스턴스가 생성되어있으니까 메소드 호출 가능.
        public override bool IsInside(double x, double y)
        {
            return this.InsideOfCircle(x, y);
        }
    }  
}