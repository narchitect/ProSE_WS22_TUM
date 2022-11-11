using System;
namespace ProSE
{
    class mainspace
    {
       public static void Main(string[] args)
       {
           Console.WriteLine("Enter Real");
           double re = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Enter Im");
           double im = Convert.ToDouble(Console.ReadLine());
           Complex example01 = new Complex(re,im);
           Console.WriteLine(example01.Norm(re, im));
       }

    }
    

}