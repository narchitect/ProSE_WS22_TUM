using System;

namespace Assignment{

    public abstract class ImplicitGeometry
    {
        // abstract method 이려면, 클래스도 abstract

        //method 1) IsInside
        public abstract bool IsInside (double x, double y);

        //method 2) Visualise 
        public void Visualize(double[] xGrid, double[] yGrid)
        {
            double xMax = xGrid[1];
            double xMin = xGrid[0];
            double yMax = yGrid[1];
            double yMin = yGrid[0];

        //x, y축과 관련됌.double x = xMin; x <= xMax; x++
            for (double y = yMin; y <= yMax; y++)
            {
                Console.WriteLine();
                for (double x = xMin; x <= xMax; x++)
                {
                    if (this.IsInside(x,y) == true)
                    {
                        Console.Write("@");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}