using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (accuracy < 0 ||accuracy > 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            bool empty = true;
            for (int i = 0; i < array.Length; i++)
            {
                double right = 0;
                double left = 0;
                for (int j = 0, k = array.Length - 1; j < i || k > i; j++, k--)
                {
                    if (j < i)
                        left += array[j];
                    if (k > i)
                        right += array[k];
                }
                if (Math.Abs(left - right) < accuracy)
                {
                    return i;
                }
                if (array[i] != 0)
                {
                    empty = false;
                }
            }
            if(empty==true)
            {
                throw new ArgumentException();
            }
            return null;
        }
    }
}
