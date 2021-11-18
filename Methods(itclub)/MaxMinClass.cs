using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_itclub_
{
    public static class MaxMinClass
    {
        public static int min(this int x, params int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i <arr.Length; i++)
            {
                if (min>arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public static int max(this int x, params int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
