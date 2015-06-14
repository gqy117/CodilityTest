namespace Codility
{
    using System;
    using System.Linq;

    public class MaxSliceSum
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int[] sliceSum = new int[N];
            int sliceNum = 0;

            for (int i = 0; i < N; i++)
            {
                int a = A[i];

                if (A[i] < 0)
                {
                    sliceNum++;
                    sliceSum[sliceNum] += a;
                    sliceNum++;
                }
                else
                {
                    sliceSum[sliceNum] += a;
                }
            }

            return sliceSum.Max(x => x);
        }
    }
}
