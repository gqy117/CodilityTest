namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            IList<int> expectedList = new List<int>();

            for (int i = 0; i < X; i++)
            {
                expectedList.Add(i + 1);
            }

            for (int K = 0; K < A.Length; K++)
            {
                if (expectedList.Contains(A[K]))
                {
                    expectedList.Remove(A[K]);
                }

                if (0 == expectedList.Count)
                {
                    return K;
                }
            }

            return -1;
        }
    }
}
