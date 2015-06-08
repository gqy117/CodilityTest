namespace Codility
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Equilibrium
    {
        public static int Solution(int[] a)
        {
            long sumAll = a.Select(x => (long)x).Sum();
            long sumLeft = 0;

            for (int balanceNumber = 0; balanceNumber < a.Length; balanceNumber++)
            {
                int balanceValue = a[balanceNumber];

                long sumRight = sumAll - sumLeft - balanceValue;

                if (sumLeft == sumRight)
                {
                    return balanceNumber;
                }

                sumLeft += balanceValue;
            }

            return -1;
        }
    }
}