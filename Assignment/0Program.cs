using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // //1) Gtter, Setter 메소드 형태 Getter, Setter는 인스턴스 함수이기때문에, 인스턴스를 생성해야함.
            // //private field값을 5롤 set
            // circle.SetRadius(5);
            // //get a changed field value 
            // circle.GetRadius();
            
            // 2) Property를 주었을 때는, 인스턴스의 메소드를 호출하고 값을 지정하는 방식. @@근데 왜 assignment 형식일까?
           
            Circle circle = new Circle(10, 0, 0);
            Rectangle rectangle = new Rectangle(-10,-10,10,10);

            Union unitedCR = new Union(circle,rectangle);

            double[] xGrid = new double[2] {-10,10};
            double[] yGrid = new double[2] {-10,10};
            
            // circle.Visualize(xGrid, yGrid);
            // rectangle.Visualize(xGrid,yGrid);
            unitedCR.Visualize(xGrid,yGrid);
            
            
            
        }
    }
}
