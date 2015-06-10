namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PermMissingElem
    {
        public static int Solution(int[] A)
        {
            if (0 == A.Length)
            {
                return 1;
            }

            var orderedList = A.ToList().OrderBy(x => x).ToList();

            for (int i = 0; i < orderedList.Count; i++)
            {
                if (orderedList[i] != 1 + i)
                {
                    return 1 + i;
                }
            }

            return orderedList.Last() + 1;
        }
    }
}
