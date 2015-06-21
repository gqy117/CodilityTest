namespace Codility
{
    using System;
    using System.Collections.Generic;

    public class CountDistinctSlices
    {
        public static int Solution(int M, int[] A)
        {
            int N = A.Length;
            if (N == 1)
            {
                return 1;
            }

            Dictionary<int, int> lastPosition = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                lastPosition[A[i]] = -1;
            }

            int count = 0;
            int start = -1;

            for (int end = 0; end < N; end++)
            {
                if (lastPosition[A[end]] > start)
                {
                    start = lastPosition[A[end]];
                }

                count += end - start;

                lastPosition[A[end]] = end;
            }

            return count;
        }
    }
}
