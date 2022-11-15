using System;

namespace Ex2._3_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial.nrm(10));
        }

        public class factorial 
        {
            public static int nrm(int n)
            {
                int[] arrayN = new int[n-1];
                for ( int j = 1; j < n; j++)
                {
                    int temp1 = n-j;
                    arrayN[j-1] = temp1;
                }
                for (int i = 0; i <arrayN.Length; i++)
                {
                    n = arrayN[i]*n;
                }
                return n;
            }
        }
    }
}


