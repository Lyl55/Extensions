using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_itclub_
{
    public static class Powclass
    {
        public static int pow(int x, int y)
        {
            int p = x;
            if (y == 1)
            {
                return p;
            }
            else if (y == 0)
            {
                return 1;
            }

            for (int i = 1; i!=y; i++)
            {
                p *= x;
            }
            return p;
        }
    }
}
