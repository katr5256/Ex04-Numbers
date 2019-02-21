using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Numbers
{
    public class Numbers
    {
        /*
        public static int RectangleArea(int lenght, int width)
        {
            return lenght * width;
        }
        */

        public static int Sum(int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum = ints[i] + sum;
            }   
            return sum;
        }

        public static int Min(int[] ints)
        {
            int min = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (min > ints[i])
                {
                    min = ints[i];
                }
            }
            return min;
        }


        public static int Max(int[] ints)
        {
            int max = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {
                if (max < ints[i])
                {
                    max = ints[i];
                }
            }
            return max;
        }
    }
}
