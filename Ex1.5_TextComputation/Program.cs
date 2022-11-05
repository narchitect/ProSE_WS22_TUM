using System;
namespace ProSE
{
    public class Exercise03
    {
        static void Main()
        {
            int[] salaries = new int[] { 10000, 50000, 220000, 7000000 };
            int[] salaryLimits = new int[] { 10000, 60000, 280000, 280000 };
            int[] TaxPercentage = new int[] { 0, 25, 42, 45 };

            for (int i = 0; i < (salaries.Length); i++)
            {
                if (salaries[i] <= salaryLimits[0])
                {
                    Console.WriteLine($"the taxt percent of your income {salaries[i]} is {TaxPercentage[0]}%");
                }
                if (salaries[i] > salaryLimits[0] && salaries[i] <= salaryLimits[1])
                {
                    Console.WriteLine($"the taxt percent of your income {salaries[i]} is {TaxPercentage[1]}%");
                }
                if (salaries[i] > salaryLimits[1] && salaries[i] <= salaryLimits[2])
                {
                    Console.WriteLine($"the taxt percent of your income {salaries[i]} is {TaxPercentage[2]}%");
                }
                if (salaries[i] > salaryLimits[3])
                {
                    Console.WriteLine($"the taxt percent of your income {salaries[i]} is {TaxPercentage[3]}%");
                }
            }

        }
    }
}

