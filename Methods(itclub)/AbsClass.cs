using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_itclub_
{
    public static class AbsClass
    {
        public static int abs(int n)
        {
            if (n<0)
            {
                n = n * -1;
            }

            return n;
        }
    }
}
