namespace ByndyusoftTestTask.Library
{
    public static class ArrayUtility
    {
        public static int SumTwoMinsInArray(int[] array)
        {
            if(array == null || array.Length < 2) 
            {
                throw new ArgumentException("Array must exists and contains less than 2 numbers");
            }

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
