using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_itclub_
{
    public static class ContainsClass
    {
        public static bool Contains(this string str, params string[] array)
        {
            for (int i = 0; i <array.Length; i++)
            {
                if (str.Contains(array[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
