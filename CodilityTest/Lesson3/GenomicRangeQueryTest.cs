namespace CodilityTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class GenomicRangeQueryTest
    {
        [Test]
        [TestCase("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }, new int[] { 2, 4, 1 })]
        public void MaxCounters_Default(string S, int[] P, int[] Q, int[] expected)
        {
            ExecuteSolution(S, P, Q, expected);
        }

        [Test]
        [TestCase(100000, new int[] { 2, 5, 0 }, new int[] { 4, 5, 99999 }, new int[] { 1, 1, 1 })]
        public void MaxCounters_N100000(int N, int[] P, int[] Q, int[] expected)
        {
            StringBuilder S = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                S.Append("A");
            }

            ExecuteSolution(S.ToString(), P, Q, expected);
        }

        [Test]
        [TestCase(100000, 50000)]
        public void MaxCounters_N100000_M50000(int N, int M)
        {
            StringBuilder S = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                int mod = Mod4(i);
                S.Append(GenomicRangeQuery.GetChar(mod));
            }

            int[] P, Q, expected;
            P = Q = expected = new int[M];

            for (int i = 0; i < M; i++)
            {
                P[i] = i;
                Q[i] = i;
                expected[i] = 1;
            }

            ExecuteSolution(S.ToString(), P, Q, expected);
        }

        [Test]
        [TestCase(100000, 50000)]
        public void MaxCounters_N100000_M50000_ACGT(int N, int M)
        {
            StringBuilder S = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                S.Append("A");
            }

            int[] P, Q, expected;
            P = Q = expected = new int[M];

            for (int i = 0; i < M; i++)
            {
                P[i] = i;
                Q[i] = i;
                expected[i] = GenomicRangeQuery.GetNum(S[i]);
            }

            ExecuteSolution(S.ToString(), P, Q, expected);
        }

        private static int Mod4(int i)
        {
            if (0 <= i && i <= 3)
            {
                return i;
            }

            return (i % 4) + 1;
        }

        private static void ExecuteSolution(string S, int[] P, int[] Q, int[] expected)
        {
            // Arrange

            // Act
            var actual = GenomicRangeQuery.Solution(S, P, Q);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
