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
    public class MinAvgTwoSliceTest
    {
        [Test]
        [TestCase(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1)]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 3, 2, 1 }, 1)]
        [TestCase(new int[] { 1, 2, 9, 1, 2, 1 }, 3)]
        public void MinAvgTwoSlice_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 10000, 10000 }, 0)]
        [TestCase(new int[] { -10000, -10000 }, 0)]
        [TestCase(new int[] { -10000, 10000 }, 0)]
        [TestCase(new int[] { 10000, -10000 }, 0)]
        public void MinAvgTwoSlice_N2_Max_Min(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 10000, 0)]
        [TestCase(100000, -10000, 0)]
        public void MinAvgTwoSlice_N100000_Max_Min(int N, int element, int expected)
        {
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = element;
            }

            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = MinAvgTwoSlice.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
