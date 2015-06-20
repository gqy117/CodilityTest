namespace Codility
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ChocolatesByNumbers
    {
        public static int Solution(int N, int M)
        {
            bool[] isChocolateEaten = new bool[N];
            IList<int> chocolateEaten = new List<int>();

            int result = 0;
            int i = 0;

            while (!isChocolateEaten[i])
            {
                // chocolateEaten.Add(i);
                isChocolateEaten[i] = true;
                result++;

                i += M;
                i = i >= N ? i % N : i;
            }

            return result;
        }
    }
}
