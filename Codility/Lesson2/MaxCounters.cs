namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaxCounters
    {
        public static int[] Solution(int N, int[] A)
        {
            int[] counters = new int[N];
            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = 0;
            }

            int currentMax = 0;
            int currentCountValue = 0;

            for (int K = 0; K < A.Length; K++)
            {
                int X = A[K];

                if (1 <= X && X <= N)
                {
                    counters[X - 1]++;
                    currentCountValue = counters[X - 1];
                    currentMax = Math.Max(currentMax, currentCountValue);
                }
                else
                {
                    for (int i = 0; i < counters.Length; i++)
                    {
                        counters[i] = currentMax;
                    }
                }
            }

            return counters;
        }
    }
}
