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
    public class TapeEquilibriumTest
    {
        [Test]
        [TestCase(new int[] { 3, 1, 2, 4, 3 }, 1)]
        public void TapeEquilibrium_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, 1)]
        public void TapeEquilibrium_NEquals2(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1000, -1000, 1 }, 1)]
        public void TapeEquilibrium_NEquals3_1000_Minis1000_1(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        public void TapeEquilibrium_NEquals100000_EachElementIsNegative1000()
        {
            int n = 100000;
            int[] A = new int[n];
            int expected = 0;

            for (int i = 0; i < 100000; i++)
            {
                A[i] = -1000;
            }
            
            ExecuteSolution(A, expected);
        }

        [Test]
        public void TapeEquilibrium_NEquals100000_EachElementIs1000()
        {
            int n = 100000;
            int[] A = new int[n];
            int expected = 0;

            for (int i = 0; i < 100000; i++)
            {
                A[i] = 1000;
            }

            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { int.MaxValue, int.MaxValue, 1 }, 1)]
        public void TapeEquilibrium_NEquals3_Max_Max_1(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = TapeEquilibrium.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
