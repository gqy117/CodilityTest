namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AbsDistinct
    {
        public static int Solution(int[] A)
        {
            Dictionary<long, long> distinctValue = new Dictionary<long, long>();
            int count = 0;
            IList<long> longA = A.Select(x => (long)x).ToList();

            for (int i = 0; i < A.Length; i++)
            {
                long abs = Math.Abs(longA[i]);

                if (!distinctValue.ContainsKey(abs))
                {
                    distinctValue.Add(abs, abs);
                    count++;
                }
            }

            return count;
        }
    }
}
