namespace CodilityTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;
    using Codility;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class MaxCountersTest
    {
        [Test]
        [TestCase(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
        public void MaxCounters_Default(int N, int[] A, int[] expected)
        {
            ExecuteSolution(N, A, expected);
        }

        [Test]
        public void MaxCounters_MaxN()
        {
            int N = 100000;
            int M = 100000;
            int[] A = new int[M];

            for (int i = 0; i < M; i++)
            {
                A[i] = i + 1;
            }

            int[] expected = new int[M];
            for (int i = 0; i < M; i++)
            {
                expected[i] = 1;
            }

            ExecuteSolution(N, A, expected);
        }

        [Test]
        [TestCase(100000, new int[] { 100001 })]
        public void MaxCounters_MaxN_A0Equals100001(int N, int[] A)
        {
            int[] expected = new int[N];

            for (int i = 0; i < expected.Length; i++)
            {
                expected[i] = 0;
            }

            ExecuteSolution(N, A, expected);
        }

        [Test]
        [TestCase(1, new int[] { 2, 1 }, new int[] { 1 })]
        public void MaxCounters_NEquals1(int N, int[] A, int[] expected)
        {
            ExecuteSolution(N, A, expected);
        }

        private static void ExecuteSolution(int N, int[] A, int[] expected)
        {
            // Arrange

            // Act
            var actual = MaxCounters.Solution(N, A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
