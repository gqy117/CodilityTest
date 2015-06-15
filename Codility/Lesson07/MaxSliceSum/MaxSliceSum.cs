namespace Codility
{
    using System;

    public class MaxSliceSum
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int currentMaxSum = A[0];
            int lastMaxSum = currentMaxSum;
            int result = A[0];

            for (int i = 1; i < N; i++)
            {
                int current = A[i];

                /*if lastMaxSum is negative, then there is no need to add a negative value.
                    Use current value as the MaxSum*/
                if (lastMaxSum < 0)
                {
                    currentMaxSum = current;
                }
                else
                {
                    currentMaxSum += current;
                }

                // Log the MaxSum ever
                result = Math.Max(result, currentMaxSum);

                // Remember the last MaxSum
                lastMaxSum = currentMaxSum;
            }

            return result;
        }
    }
}
