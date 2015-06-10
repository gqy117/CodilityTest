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
    public class MissingIntegerTest
    {
        [Test]
        [TestCase(new int[] { 1, 3, 6, 4, 1, 2 }, 5)]
        public void MaxCounters_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 2 }, 1)]
        public void MaxCounters_N1_Element2(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1 }, 2)]
        public void MaxCounters_N1_Element1(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { int.MaxValue }, 1)]
        public void MaxCounters_N1_ElementMax(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { int.MaxValue, int.MaxValue }, 1)]
        public void MaxCounters_N2_ElementMax_ElementMax(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { int.MaxValue, int.MinValue }, 1)]
        public void MaxCounters_N2_ElementMax_ElementMin(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 1)]
        public void MaxCounters_N100000_ElementAllMax(int N, int expected)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = int.MaxValue;
            }

            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 1)]
        public void MaxCounters_N100000_ElementAllMin(int N, int expected)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = int.MinValue;
            }

            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 2)]
        public void MaxCounters_N100000_ElementAllMin_And1(int N, int expected)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = int.MinValue;
            }

            A[0] = 1;

            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 100001)]
        public void MaxCounters_N100000_ElementOneByOne(int N, int expected)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = i + 1;
            }

            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { int.MinValue, int.MinValue }, 1)]
        public void MaxCounters_N2_ElementMin_ElementMin(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = MissingInteger.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
