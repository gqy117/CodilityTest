namespace Codility
{
    using System;

    public class NumberOfDiscIntersections
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int intersectedCount = 0;

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    long radiusOfLeftRound = A[i];
                    long maxOfLeftRound = i + radiusOfLeftRound;

                    long radiusOfRightRound = A[j];
                    long minOfRightRound = j - radiusOfRightRound;

                    if (maxOfLeftRound >= minOfRightRound)
                    {
                        intersectedCount++;
                    }
                }
            }

            return intersectedCount;
        }
    }
}
