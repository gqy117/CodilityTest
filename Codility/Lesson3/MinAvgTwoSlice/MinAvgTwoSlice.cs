namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class MinAvgTwoSlice
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int minP = int.MaxValue;
            double minAvg = int.MaxValue;
            double currentAvg;

            for (int P = 0; P < N - 1; P++)
            {
                int Q = P + 1;

                double currentAvg2 = (double)(A[P] + A[Q]) / 2;
                if (Q + 1 < N)
                {
                    double currentAvg3 = (double)(A[P] + A[Q] + A[Q + 1]) / 3;
                    currentAvg = Math.Min(currentAvg2, currentAvg3);
                }
                else
                {
                    currentAvg = currentAvg2;
                }

                if (currentAvg < minAvg)
                {
                    minAvg = currentAvg;
                    minP = P;
                }
            }

            return minP;
        }
    }
}
