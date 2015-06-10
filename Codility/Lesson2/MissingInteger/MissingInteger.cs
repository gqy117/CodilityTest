namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MissingInteger
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            bool[] existIn = new bool[N];

            for (int i = 0; i < N; i++)
            {
                if (0 <= A[i] - 1 && A[i] - 1 < N)
                {
                    existIn[A[i] - 1] = true;
                }
            }

            for (int i = 0; i < existIn.Length; i++)
            {
                if (!existIn[i])
                {
                    return i + 1;
                }
            }

            return N + 1;
        }
    }
}
