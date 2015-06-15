namespace Codility
{
    using System;

    public class MaxDoubleSliceSum
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int X = 0;
            int Y = 1;
            int Z = N - 1;
            int totalLoseCausedByX = A[0];
            int totalLoseCausedByY = A[1];
            int totalLoseCausedByZ = A[N - 1];
            int sum = 0;

            for (int i = 0; i < N - 2; i++)
            {
                int current = A[i];

                if (current + sum < totalLoseCausedByX)
                {
                    X = i;
                    Y = X + 1;
                    totalLoseCausedByY = A[Y];
                }
                else if (i > X)
                {
                    if (current < totalLoseCausedByY)
                    {
                        Y = i; 
                        totalLoseCausedByY = Math.Min(current, totalLoseCausedByY);
                    }
                }

                totalLoseCausedByX = Math.Min(current + sum, totalLoseCausedByX);
                sum += current;
            }

            int all = sum + A[N - 1] + A[N - 2];

            sum = 0;
            for (int i = N - 1; i > X + 1; i--)
            {
                int current = A[i];

                if (current + sum < totalLoseCausedByZ)
                {
                    Z = i;
                }

                totalLoseCausedByZ = Math.Min(current + sum, totalLoseCausedByZ);
                sum += current;
            }

            return all - totalLoseCausedByX - totalLoseCausedByY - totalLoseCausedByZ;
        }
    }
}