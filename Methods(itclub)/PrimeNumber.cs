using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_itclub_
{
    public static class PrimeNumber
    {
        public static bool IsPrime(this int a)
        {
            for (int i = 2; i <=a/2; i++)
            {
                if (a%i==0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
