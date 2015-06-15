namespace Codility
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class Distinct
    {
        public static int Solution(int[] A)
        {
            IList<int> distinctedA = A.Distinct().ToList();

            return distinctedA.Count;
        }
    }
}
