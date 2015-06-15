namespace Codility.Lesson2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PermCheck
    {
        public static int Solution(int[] A, int N)
        {
            IList<int> sortedA = A.OrderBy(x => x).ToList();

            for (int i = 0; i < sortedA.Count; i++)
            {
                if (sortedA[i] != i + 1)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
