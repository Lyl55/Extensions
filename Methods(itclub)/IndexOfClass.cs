using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_itclub_
{
    public static class IndexOfClass
    {

        
        public static int[] IndexOf(this string str, params char[] chars)
        {
            int index = 0;
            int[] arr = new int[chars.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            for (int i = 0; i < str.Length; i++)   // n r a
            {
                index = 0;
                for (int j = 0; j < chars.Length; j++)
                {
                    if (str[i] == chars[j])
                    {
                        if(arr[index]==-1)
                        arr[index] = i;
                    }
                    index++;
                }
            }
            return arr.Distinct().ToArray();

        }
    }
}
