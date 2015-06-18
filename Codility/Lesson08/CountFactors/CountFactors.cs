namespace Codility
{
    using System;

    public class CountFactors
    {
        public static int Solution(int N)
        {
            int factorCount = 0;
            int A = 1;

            while (Math.Pow(A, 2) <= N)
            {
                if (0 == N % A)
                {
                    if (Math.Pow(A, 2) == N)
                    {
                        factorCount++;
                    }
                    else
                    {
                        factorCount += 2;
                    }
                }

                A++;
            }

            return factorCount;
        }
    }
}
