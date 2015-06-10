namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountDiv
    {
        public static int Solution(int A, int B, int K)
        {
            int minDiVisible = (int)Math.Ceiling((double)A / (double)K) * K;
            int maxDiVisible = (int)Math.Floor((double)B / (double)K) * K;

            return ((maxDiVisible - minDiVisible) / K) + 1;
        }
    }
}
