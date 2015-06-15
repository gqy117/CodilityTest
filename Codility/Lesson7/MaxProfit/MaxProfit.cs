namespace Codility
{
    using System;

    public class MaxProfit
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int currentAccumulatedProfit = 0;
            int maxProfit = 0;

            for (int i = 0; i < N - 1; i++)
            {
                int currentProfit = A[i + 1] - A[i];

                currentAccumulatedProfit = Math.Max(currentProfit, currentAccumulatedProfit + currentProfit);
                maxProfit = Math.Max(maxProfit, currentAccumulatedProfit);
            }

            return maxProfit;
        }
    }
}