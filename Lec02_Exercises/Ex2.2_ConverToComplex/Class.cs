using System;
namespace ProSE
{
    public class Complex
    {
        public Complex()
        {
            
        }

        public static bool TryParseComplex(string userInput)
        {

            if (userInput.Contains("+") == true && userInput.Contains("i") == true)
            {
                int found = userInput.IndexOf("+");
                string re = userInput.Substring(found, found + 1);
                string im = userInput.Substring(found);

                var doubleRe = Convert.ToDouble(re);
                var doubleIm = Convert.ToDouble(im);

                return true;
            }

            else
            {
                return false;
            }
        }
        //private static bool IsValidComplex(string userInput, out double real, out double imaginary);
        //{

        //}

    }
}

