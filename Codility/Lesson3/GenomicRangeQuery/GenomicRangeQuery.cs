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
            int N = S.Length;
            int M = P.Length;
            int[] result = new int[M];
            char[] charS = S.ToCharArray();

            int[] occuranceA, occuranceC, occuranceG, occuranceT;
            occuranceA = new int[N + 1];
            occuranceC = new int[N + 1];
            occuranceG = new int[N + 1];
            occuranceT = new int[N + 1];

            for (int i = 0; i < N; i++)
            {
                var a = IsA(charS[i]);
                var c = IsC(charS[i]);
                var g = IsG(charS[i]);
                var t = IsT(charS[i]);

                occuranceA[i + 1] = occuranceA[i] + a;
                occuranceC[i + 1] = occuranceC[i] + c;
                occuranceG[i + 1] = occuranceG[i] + g;
                occuranceT[i + 1] = occuranceT[i] + t;
            }

            for (int K = 0; K < M; K++)
            {
                int fromIndex = P[K];
                int toIndex = Q[K] + 1;

                if (occuranceA[toIndex] - occuranceA[fromIndex] > 0)
                {
                    result[K] = 1;
                }
                else if (occuranceC[toIndex] - occuranceC[fromIndex] > 0)
                {
                    result[K] = 2;
                }
                else if (occuranceG[toIndex] - occuranceG[fromIndex] > 0)
                {
                    result[K] = 3;
                }
                else if (occuranceT[toIndex] - occuranceT[fromIndex] > 0)
                {
                    result[K] = 4;
                }
            }

            return result;
        }

        public static int GetNum(char c)
        {
            int num = 0;
            switch (c)
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

        public static char GetChar(int i)
        {
            char c = ' ';
            switch (i)
            {
                case 1:
                    c = 'A';
                    break;
                case 2:
                    c = 'C';
                    break;
                case 3:
                    c = 'G';
                    break;
                case 4:
                    c = 'T';
                    break;
            }

            return c;
        }

        private static int[] ConvertCharArrayToIntArray(int N, char[] charS)
        {
            int[] intS = new int[N];

            for (int i = 0; i < N; i++)
            {
                var num = GetNum(charS[i]);
                intS[i] = num;
            }

            return intS;
        }

        private static int IsA(char c)
        {
            int a = ('A' == c) ? 1 : 0;

            return a;
        }

        private static int IsC(char c)
        {
            int a = ('C' == c) ? 1 : 0;

            return a;
        }

        private static int IsG(char c)
        {
            int a = ('G' == c) ? 1 : 0;

            return a;
        }

        private static int IsT(char c)
        {
            int a = ('T' == c) ? 1 : 0;

            return a;
        }
    }
}
