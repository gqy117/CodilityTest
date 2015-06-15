namespace Codility
{
    using System;

    public class MaxDoubleSliceSum
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int[] K1 = new int[N];
            int[] K2 = new int[N];
            int result = 0;

            for (int i = 1; i < N - 1; i++)
            {
                K1[i] = Math.Max(0, K1[i - 1] + A[i]);
            }

            for (int i = N - 2; i > 0; i--)
            {
                K2[i] = Math.Max(0, K2[i + 1] + A[i]);
            }

            for (int i = 1; i < N - 1; i++)
            {
                result = Math.Max(result, K1[i - 1] + K2[i + 1]);
            }

            return result;
        }
    }
}