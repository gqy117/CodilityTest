namespace Codility
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSemiprimes
    {
        public static int[] Solution(int N, int[] P, int[] Q)
        {
            if (1 == N)
            {
                return new int[] { 0 };
            }

            IList<int> primeNumbers = new List<int>();

            Dictionary<int, bool?> status = new Dictionary<int, bool?>();
            Dictionary<int, int> semiPrimeStatus = new Dictionary<int, int>();

            semiPrimeStatus.Add(0, 0);
            semiPrimeStatus.Add(1, 0);

            for (int i = 2; i <= N; i++)
            {
                primeNumbers.Add(i);
                status.Add(i, null);
                semiPrimeStatus.Add(i, 0);
            }

            for (int i = 2; i * i <= N; i++)
            {
                if (null == status[i])
                {
                    for (int k = i * i; k <= N; k += i)
                    {
                        if (primeNumbers.Contains(k))
                        {
                            primeNumbers.Remove(k);
                            status[k] = false;
                        }
                    }
                }
            }

            IList<int> semiPrimes = new List<int>();

            for (int i = 0; Math.Pow(primeNumbers[i], 2) <= N; i++)
            {
                for (int j = i; primeNumbers[i] * primeNumbers[j] <= N; j++)
                {
                    int product = primeNumbers[i] * primeNumbers[j];
                    semiPrimes.Add(product);
                }
            }

            semiPrimes = semiPrimes.OrderBy(x => x).ToList();

            int totalSemiPrime = 0;
            foreach (var semiPrime in semiPrimes)
            {
                totalSemiPrime++;
                semiPrimeStatus[semiPrime] = totalSemiPrime;
            }

            for (int i = 1; i <= N; i++)
            {
                semiPrimeStatus[i] = 0 == semiPrimeStatus[i] ? semiPrimeStatus[i - 1] : semiPrimeStatus[i];
            }

            int[] result = new int[P.Length];

            for (int i = 0; i < P.Length; i++)
            {
                int allSemiPrime = semiPrimeStatus[Q[i]];
                int primeToBeExcepted = semiPrimeStatus[P[i] - 1];

                result[i] = allSemiPrime - primeToBeExcepted;
            }

            return result;
        }
    }
}