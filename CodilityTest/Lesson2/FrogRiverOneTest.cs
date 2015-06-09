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
    public class FrogRiverOneTest
    {
        [Test]
        [TestCase(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }, 6)]
        public void MaxCounters_Default(int X, int[] A, int expected)
        {
            ExecuteSolution(X, A, expected);
        }

        [Test]
        [TestCase(2, new int[] { 1 }, -1)]
        public void MaxCounters_NEquals1_XEquals2(int X, int[] A, int expected)
        {
            ExecuteSolution(X, A, expected);
        }

        [Test]
        [TestCase(1, new int[] { 1 }, 0)]
        public void MaxCounters_NEquals1_XEquals1(int X, int[] A, int expected)
        {
            ExecuteSolution(X, A, expected);
        }

        [Test]
        [TestCase(1, new int[] { 100000 }, -1)]
        public void MaxCounters_BigAValue_XEquals1(int X, int[] A, int expected)
        {
            ExecuteSolution(X, A, expected);
        }

        [Test]
        [TestCase(100000, 99999)]
        public void MaxCounters_N100000_X100000(int X, int expected)
        {
            int N = 100000;
            int[] A = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = i + 1;
            }

            ExecuteSolution(X, A, expected);
        }

        private static void ExecuteSolution(int X, int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = FrogRiverOne.Solution(X, A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
