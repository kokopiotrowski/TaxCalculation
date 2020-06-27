using System;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Write:\n 1 - calculate your tax\n 2 - exit the program\n");

                int x = int.Parse(Console.ReadLine());

                switch(x)
                {
                    case 1:
                        Console.WriteLine("Enter your yearly earnings (currency PLN)");
                        double earnings = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter ammount of kids you have: ");
                        int kids = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tax you need to pay: " + TaxCalculator.GetTaxForEarnings(earnings)
                            + "\nBonus for children: " + TaxCalculator.GetBonusForChildren(kids));
                        break;
                    case 2:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("I don't understand the command.");
                        break;

                }
                    
                    
             }

        }
    }
}
