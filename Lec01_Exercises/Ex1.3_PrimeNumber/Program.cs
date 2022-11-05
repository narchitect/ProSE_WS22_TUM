using System;
namespace ProSE
{
    public class Exercise02
    {
        static void Main(string[] args)
        {
            // getting input from a user
            Console.WriteLine("Type the number");
            var input = Console.ReadLine();
            int inputInt = Convert.ToInt32(input);


            // cotain for divisors of the input
            List<int> setList = new List<int>();


            // checking if the input is prime or not
            int i = 2;
            do
            {
                if (inputInt % i == 0)
                {
                    Console.WriteLine("it's not prime number");
                    setList.Add(i);
                }
                else
                {
                    i++;
                }
            }
            while (setList.Count < 1 && i < inputInt);

            // if input itself is the only one in divors container, then print it.
            if (setList.Count == 0)
            {
                Console.WriteLine("your input is prime.");
            }
        }
    }
}

