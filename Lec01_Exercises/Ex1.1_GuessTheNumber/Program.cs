using System;
namespace ProSE
{
    public class Excerise04
    {
        static void Main(String[] args)
        {
            int[] secretNums = new int[] { 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine("Guess the number");
            var input = Console.ReadLine();
            var inputInt = Convert.ToInt32(input);

            while (Array.IndexOf(secretNums, inputInt) == -1)
            {
                if (inputInt < secretNums[0])
                {
                    Console.WriteLine("Higher, Guess it again");
                    var newInput = Console.ReadLine();
                    var newInputInt = Convert.ToInt32(newInput);
                    inputInt = newInputInt;
                }
                if (inputInt > secretNums[6])
                {
                    Console.WriteLine("Lower, Guess it again");
                    var newInput = Console.ReadLine();
                    var newInputInt = Convert.ToInt32(newInput);
                    inputInt = newInputInt;
                }
            }

            Console.WriteLine("You guess the number correctly");
        }
    }
}