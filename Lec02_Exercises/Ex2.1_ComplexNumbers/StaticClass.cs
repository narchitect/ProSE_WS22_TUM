
using System;
namespace ProSE
{
    public class Complex
    {
        //field
        // double re;
        // double im;

        //constructor 
        // public Complex(double re, double im)
        // {
        //    this.re = re;
        //    this.im = im;
        // }
        public static double Norm(double Re, double Im)
        {
           double nrm;
           nrm = Math.Sqrt(Re * Re + Im);
           return nrm;
        }
    }
}