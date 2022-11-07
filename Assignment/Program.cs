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
           
           
            double[] xGrid = new double[2] {0,15};
            double[] yGrid = new double[2] {0,5};

            Rectangle background_rectangle = new Rectangle(0,0,14,5);
            Rectangle rec1 = new Rectangle(0,2,0,5);
            Rectangle rec2 = new Rectangle(3,2,3,5);
            Rectangle rec3 = new Rectangle(6,0,6,3);
            Rectangle rec4 = new Rectangle(9,2,9,5);
            Rectangle rec5 = new Rectangle(12,2,12,5);

           
            Difference Diff_TUM = new Difference(background_rectangle, rec1);
            Diff_TUM = new Difference(Diff_TUM, rec2);
            Diff_TUM = new Difference(Diff_TUM, rec3);
            Diff_TUM = new Difference(Diff_TUM, rec4);
            Diff_TUM = new Difference(Diff_TUM, rec5);

            Diff_TUM.Visualize(xGrid,yGrid);


            




            // Rectangle rectangle = new Rectangle(0,0,10,6);

            // Rectangle rectangle1 = new Rectangle(0,0,1,5);
            // Rectangle rectangle2 = new Rectangle(2,0,3,5);
            // Rectangle rectangle3 = new Rectangle(4,1,5,6);
            // Rectangle rectangle4 = new Rectangle(6,0,7,5);
            // Rectangle rectangle5 = new Rectangle(8,0,9,5);

            // Difference diff_TUM = new Difference(rectangle,rectangle1);
            // Difference diff_TUM2 = new Difference(diff_TUM,rectangle2);
            // Difference diff_TUM3 = new Difference(diff_TUM2,rectangle3);
            // Difference diff_TUM4 = new Difference(diff_TUM3,rectangle4);
            // Difference diff_TUM5 = new Difference(diff_TUM4,rectangle5);

            // rectangle.Visualize(xGrid,yGrid);
            // diff_TUM.Visualize(xGrid,yGrid);
            // diff_TUM5.Visualize(xGrid,yGrid);



            
            
            
        }
    }
}
