using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_itclub_
{
    public static class EndsWithClass
    {
        public static bool EndsWith(this string str, params string[] arr)
        {
            for (int i = 0; i <arr.Length; i++)
            {
                if (str.EndsWith(arr[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
