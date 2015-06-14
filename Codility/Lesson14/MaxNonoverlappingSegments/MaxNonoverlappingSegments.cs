namespace Codility
{
    using System;

    public class MaxNonoverlappingSegments
    {
        public static int Solution(int[] A, int[] B)
        {
            int N = A.Length;
            int result = 0;
            int lastValue = -1;

            for (int i = 0; i < N; i++)
            {
                if (A[i] > lastValue)
                {
                    result++;
                    lastValue = B[i];
                }
            }

            return result;
        }
    }
}