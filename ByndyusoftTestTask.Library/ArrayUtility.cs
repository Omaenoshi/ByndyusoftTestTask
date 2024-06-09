﻿namespace ByndyusoftTestTask.Library
{
    public static class ArrayUtility
    {
        public static int SumTwoMinsInArray(int[] array)
        {
            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            foreach (int e in array)
            {
                if (e < min1)
                {
                    min2 = min1;
                    min1 = e;
                }
                else if (e < min2)
                {
                    min2 = e;
                }
            }

            return min1 + min2;
        }
    }
}
