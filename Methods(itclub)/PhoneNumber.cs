using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_itclub_
{
    public static class PhoneNumber
    {
        public static bool IsNumber(this string num)
        {
            int c = 0;
            if (num.Substring(0,4)=="+994" && num.Length==13)
            {
                for (int i = 4; i <num.Length; i++)
                {
                    if (num[i]>=48 && num[i]<=57)
                    {
                        c++;
                    }
                }

                if (c==9)
                {
                    return true;
                }
                
            }

            return false;
        }
    }
}
