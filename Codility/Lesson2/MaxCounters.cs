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
            int currentMax = 0;
            int currentMin = 0;

            for (int K = 0; K < A.Length; K++)
            {
                int X = A[K];

                if (1 <= X && X <= N)
                {
                    if (counters[X - 1] < currentMin)
                    {
                        counters[X - 1] = currentMin;
                    }

                    counters[X - 1]++;
                    currentMax = Math.Max(currentMax, counters[X - 1]);
                }
                else
                {
                    currentMin = currentMax;
                }
            }

            for (int i = 0; i < counters.Length; i++)
            {
                counters[i] = counters[i] < currentMin ? currentMin : counters[i];
            }

            return counters;
        }
    }
}
