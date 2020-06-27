using System;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (true)
            {
                Console.Write("Write:\n 1 - calculate your tax\n 2 - exit the program\n");
                try
                {
                    x = int.Parse(Console.ReadLine());
                }
                catch
                {
                    x = -1;   
                }

                switch(x)
                {
                    case 1:

                        double earnings;
                        int kids;
                        try
                        {
                            Console.WriteLine("Enter your yearly earnings (currency PLN)");
                            earnings = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter ammount of kids you have: ");
                            kids = int.Parse(Console.ReadLine());
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("Input only numbers. ");
                            break;
                        }
                        
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
