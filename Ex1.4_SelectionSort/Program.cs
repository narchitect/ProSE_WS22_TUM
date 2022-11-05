using System;
namespace ProSE
{
    public class Exercise05
    {
        static void Main(string[] args)
        {
            int[] givenNums = new int[] { 3, 6, 2, 1 };
            Console.WriteLine("[{0}]", string.Join(", ", givenNums));

            for (int i = 0; i < givenNums.Length; i++)
            {
                int minIndex = i;
                int minValue = givenNums[i];

                for (int j = i + 1; j < (givenNums.Length); j++)
                {
                    if (givenNums[j] < minValue)
                    {
                        minIndex = j;
                        minValue = givenNums[j];
                        (givenNums[i], givenNums[minIndex]) = (givenNums[minIndex], givenNums[i]);
                    }

                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", givenNums));

        }
    }
}
