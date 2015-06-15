namespace Codility
{
    using System;

    public class PassingCars
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int pairCount = 0;
            int countP = 0;
            bool zeroFirst = 0 == A[0];

            for (int i = 0; i < N; i++)
            {
                if (pairCount > 1000000000)
                {
                    return -1;
                }

                if (zeroFirst)
                {
                    switch (A[i])
                    {
                        case 0:
                            countP++;
                            break;

                        case 1:
                            pairCount += countP;
                            break;

                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
                else
                {
                    switch (A[i])
                    {
                        case 1:
                            countP++;
                            break;

                        case 0:
                            pairCount += countP;
                            break;

                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
            }

            return pairCount;
        }
    }
}
