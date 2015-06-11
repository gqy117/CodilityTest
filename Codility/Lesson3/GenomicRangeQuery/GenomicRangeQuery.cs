namespace Codility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenomicRangeQuery
    {
        public static int[] Solution(string S, int[] P, int[] Q)
        {
            int M = P.Length;
            int[] result = new int[M];
            char[] charS = S.ToCharArray();
            var intS = ConvertCharArrayToIntArray(S, charS);

            for (int K = 0; K < M; K++)
            {
                result[K] = intS.Skip(P[K]).Take(Q[K] - P[K] + 1).Min();
            }

            return result;
        }

        private static int[] ConvertCharArrayToIntArray(string S, char[] charS)
        {
            int[] intS = new int[S.Length];

            for (int i = 0; i < S.Length; i++)
            {
                var num = GetNum(charS, i);
                intS[i] = num;
            }

            return intS;
        }

        private static int GetNum(char[] charS, int i)
        {
            int num = 0;
            switch (charS[i])
            {
                case 'A':
                    num = 1;
                    break;
                case 'C':
                    num = 2;
                    break;
                case 'G':
                    num = 3;
                    break;
                case 'T':
                    num = 4;
                    break;
            }

            return num;
        }
    }
}
