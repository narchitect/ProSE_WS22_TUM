using System;

namespace ProSE
{
    class Exercise01
    {
        static void Main(string[] args)
        {
            // Writing the fisrt Password 
            Console.WriteLine("Type the password.");
            string password = "TUM Mensa is good";
            var input = Console.ReadLine();
            var inputString = Convert.ToString(input);

            // Matching the password
            if (password == inputString)
            {
                Console.WriteLine("yes, it is");
            }
            else
            {
                // Writing the second passworddd
                while (password != inputString)
                {
                    Console.WriteLine("you're wrong, type it again.");
                    var newinput = Console.ReadLine();
                    var newinputString = Convert.ToString(newinput);

                    inputString = newinputString;
                }
            }

        }
    }
}