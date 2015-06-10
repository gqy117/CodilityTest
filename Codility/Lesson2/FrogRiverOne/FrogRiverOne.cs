namespace Codility
{
    using System;
    using System.Text;
    using System.Threading.Tasks;

    public class FrogRiverOne
    {
        public static int Solution(int X, int[] A)
        {
            bool[] expectedList = new bool[X];
            int steps = X;
            for (int K = 0; K < A.Length; K++)
            {
                if (A[K] <= X && !expectedList[A[K] - 1])
                {
                    expectedList[A[K] - 1] = true;
                    steps--;
                }

                if (0 == steps)
                {
                    return K;
                }
            }

            return -1;
        }
    }
}
