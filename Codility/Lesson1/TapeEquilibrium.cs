namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            int n = A.Length;
            long sumLeft = 0;
            long sumRight = A.Select(x => (long)x).Sum() - sumLeft;

            IList<long> listDifference = new List<long>();

            for (int p = 1; p < n; p++)
            {
                sumLeft += A[p - 1];
                sumRight -= A[p - 1];
                listDifference.Add(Math.Abs(sumLeft - sumRight));
            }

            return (int)listDifference.Min();
        }
    }
}
