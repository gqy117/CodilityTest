namespace Codility
{
    using System;
    using System.Linq;

    public class MaxProductOfThree
    {
        public static int Solution(int[] A)
        {
            int N = A.Length;
            var sortedA = A.OrderByDescending(x => x).ToList();

            int positiveMax = sortedA.Take(3).Aggregate((current, next) => current * next);

            int negativeMax = 0;

            int last1 = sortedA[N - 1];
            int last2 = sortedA[N - 2];
            int first1 = sortedA[0];

            if (last1 < 0 && last2 < 0)
            {
                negativeMax = first1 * last1 * last2;
            }

            return Math.Max(positiveMax, negativeMax);
        }
    }
}
