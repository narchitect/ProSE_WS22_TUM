using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Gtter, Setter 메소드 형태 Getter, Setter는 인스턴스 함수이기때문에, 인스턴스를 생성해야함.

            // Circle circle = new Circle(5,0 ,0);
            // //private field값을 5롤 set
            // circle.SetRadius(5);
            // //get a changed field value 
            // circle.GetRadius();
            
            // 2) Property를 주었을 때는, 인스턴스의 메소드를 호출하고 값을 지정하는 방식.
           
           
            // double[] xGrid = new double[2] {0,15};
            // double[] yGrid = new double[2] {0,5};

            // Rectangle background_rectangle = new Rectangle(0,0,14,5);
            // Rectangle rec1 = new Rectangle(0,2,0,5);
            // Rectangle rec2 = new Rectangle(3,2,3,5);
            // Rectangle rec3 = new Rectangle(6,0,6,3);
            // Rectangle rec4 = new Rectangle(9,2,9,5);
            // Rectangle rec5 = new Rectangle(12,2,12,5);

           
            // Difference Diff_TUM = new Difference(background_rectangle, rec1);
            // Diff_TUM = new Difference(Diff_TUM, rec2);
            // Diff_TUM = new Difference(Diff_TUM, rec3);
            // Diff_TUM = new Difference(Diff_TUM, rec4);
            // Diff_TUM = new Difference(Diff_TUM, rec5);

            // Diff_TUM.Visualize(xGrid,yGrid);

            // double[] xGrid = new double[2] {0, 5};
            
            // 1) Setting x,y Grids
            double[] yGrid = new double[2] {0, 5};
            double[] xGrid = new double[2] {0, 20};
 
            // 2) Letter T (x 0:5)
            Rectangle T_background = new Rectangle(0,0,5,5);
            Rectangle T_rec1 = new Rectangle(0,1,1,5);
            Rectangle T_rec2 = new Rectangle(4,1,5,5);

            Difference T = new Difference(T_background, T_rec1);
            T = new Difference(T,T_rec2);

            
            // 3) Letter U (x 5:11)
            Circle inner_cirlce1 = new Circle(2,8,2);
            Circle outter_circle1 = new Circle(3,8,2);
            Ring U_ring = new Ring(outter_circle1, inner_cirlce1);
            Rectangle U_rec1 = new Rectangle(5,0,10,2);
            Difference U_curve = new Difference(U_ring, U_rec1);

            Rectangle U_rec2 = new Rectangle(5,0,6,2);
            Rectangle U_rec3 = new Rectangle(10,0,11,2);

            Union U = new Union(U_curve,U_rec2);
            U = new Union(U, U_rec3);

            // 4) Letter M (x 11:16)

            Circle inner_circle2 = new Circle(2, 15, 0);
            Circle outter_circle2 = new Circle(3, 15, 0);
            Ring M_ring = new Ring(outter_circle2, inner_circle2);

            Rectangle M_rec1 = new Rectangle(12,0,13,5);
            Rectangle M_rec2 = new Rectangle(17,0,18,5);

            Union M = new Union(M_ring, M_rec1);
            M = new Union(M, M_rec2);

            // 5) Union T U M letters
            Union TUM = new Union(T,U);
            TUM = new Union(TUM, M);

            TUM.Visualize(xGrid,yGrid);


            
            

            

            
 
            
        }
    }
}
