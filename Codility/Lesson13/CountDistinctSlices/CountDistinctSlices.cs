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

            Dictionary<int, int> distinctValue = new Dictionary<int, int>()
            {
                { A[0], A[0] }
            };

            int start = 0;
            int end = 0;
            int count = 0;

            while (end < N - 1 && start < N - 1)
            {
                int currentValue = 0;

                while (end < N - 1 && !distinctValue.ContainsKey(A[end + 1]))
                {
                    end++;
                    currentValue = A[end];
                    distinctValue.Add(currentValue, currentValue);
                    count++;
                }

                while (start <= end)
                {
                    if (start != end)
                    {
                        distinctValue.Remove(A[start]);
                        start++;
                        if (start != end)
                        {
                            count++;
                        }
                    }
                    else
                    {
                        distinctValue.Clear();
                        start++;
                        end++;
                        distinctValue.Add(A[start], A[start]);
                    }

                    break;
                }
            }

            return A.Length + count;
        }
    }
}
