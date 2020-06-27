using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculation
{
    static class TaxCalculator
    {
        public static double GetTaxForEarnings(double earnings)
        {
            if(earnings <8000)
            {
                return 0;
            }
            else if(earnings <= 85000)
            {
                return earnings * 0.18;
            }
            else
            {
                return earnings * 0.21;
            }
        }

        public static double GetBonusForChildren(int amountOfChildren)
        {
            return 500 * amountOfChildren;
        }

    }
}
