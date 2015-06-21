namespace Codility
{
    using System;
    using System.Collections.Generic;

    public class CountDistinctSlices
    {
        public static int Solution(int M, int[] A)
        {
            int N = A.Length;
            if (0 == N)
            {
                return 1;
            }

            int start = -1;
            int count = 0;
            Dictionary<int, int> lastPosition = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                lastPosition[A[i]] = -1;
            }

            for (int end = 0; end < N; end++)
            {
                if (lastPosition[A[end]] > start)
                {
                    start = lastPosition[A[end]];
                }

                count += end - start;

                if (count > 1000000000)
                {
                    return 1000000000;
                }

                lastPosition[A[end]] = end;
            }

            return count;
        }
    }
}
