namespace Codility
{
    using System;

    public class MaxSliceSum
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int maxEnding = A[0];
            int maxSlice = A[0];

            for (int i = 1; i < N; i++)
            {
                int current = A[i];
                ////if current > max + current, then use current
                maxEnding = Math.Max(current, maxEnding + current);

                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }
    }
}
