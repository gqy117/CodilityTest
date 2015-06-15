namespace Codility
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Triangle
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            IList<long> longA = A.OrderBy(x => x).Select(x => (long)x).ToList();

            for (int i = 0; i < N - 2; i++)
            {
                long a = longA[i];
                long b = longA[i + 1];
                long c = longA[i + 2];

                // Since it's already sorted, there is no need to compare b + c > a
                if (a + b > c)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
