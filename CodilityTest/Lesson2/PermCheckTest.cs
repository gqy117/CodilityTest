namespace CodilityTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Codility.Lesson2;
    using NUnit.Framework;

    [TestFixture]
    public class PermCheckTest
    {
        [Test]
        [TestCase(new int[] { 4, 1, 3, 2 }, 4, 1)]
        public void PermCheck_Default(int[] A, int N, int expected)
        {
            ExecuteSolution(A, N, expected);
        }

        [Test]
        [TestCase(new int[] { 1000000000 }, 1, 0)]
        public void PermCheck_AEquals1000000000_NEquals1(int[] A, int N, int expected)
        {
            ExecuteSolution(A, N, expected);
        }

        [Test]
        [TestCase(new int[] { 1 }, 1, 1)]
        public void PermCheck_AEquals1_NEquals1(int[] A, int N, int expected)
        {
            ExecuteSolution(A, N, expected);
        }

        [Test]
        [TestCase(1)]
        public void PermCheck_MaxA_MaxN(int expected)
        {
            int N = 100000;
            int[] A = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = i + 1;
            }

            ExecuteSolution(A, N, expected);
        }

        [Test]
        [TestCase(0)]
        public void PermCheck_EachOfAIs1000000000_MaxN(int expected)
        {
            int N = 100000;
            int[] A = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = 1000000000;
            }

            ExecuteSolution(A, N, expected);
        }

        private static void ExecuteSolution(int[] A, int N, int expected)
        {
            // Arrange

            // Act
            var actual = PermCheck.Solution(A, N);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
