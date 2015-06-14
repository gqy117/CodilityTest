namespace Codility
{
    using System;

    public class TieRopes
    {
        public static int Solution(int K, int[] A)
        {
            int N = A.Length;
            int currentLenghSum = 0;
            int result = 0;

            for (int i = 0; i < N; i++)
            {
                currentLenghSum += A[i];
                if (currentLenghSum >= K)
                {
                    result++;
                    currentLenghSum = 0;
                }
            }

            return result;
        }
    }
}
