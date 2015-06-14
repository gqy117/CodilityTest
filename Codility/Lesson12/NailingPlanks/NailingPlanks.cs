namespace Codility
{
    using System;

    public class NailingPlanks
    {
        public static int Solution(int[] A, int[] B, int[] C)
        {
            int N = A.Length;
            int M = C.Length;
            int nailCount = 0;
            int nailedPlank = 0;

            for (int i = 0; i < M; i++)
            {
                if (nailedPlank == N)
                {
                    break;
                }

                int currentNail = C[i];
                bool currentNailUsed = false;

                for (int j = nailedPlank; j < N; j++)
                {
                    if (A[j] <= currentNail && currentNail <= B[j])
                    {
                        if (!currentNailUsed)
                        {
                            currentNailUsed = true;
                            nailCount++;
                        }

                        nailedPlank++;
                    }
                    else
                    {
                        if (!currentNailUsed)
                        {
                            nailCount++;
                        }

                        break;
                    }
                }
            }

            if (nailedPlank == N)
            {
                return nailCount;
            }
            else
            {
                return -1;
            }
        }
    }
}
