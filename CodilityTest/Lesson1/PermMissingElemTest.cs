namespace CodilityTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Codility;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class PermMissingElemTest
    {
        [Test]
        [TestCase(new int[] { 2, 3, 1, 5 }, 4)]
        public void PermMissingElem_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1 }, 2)]
        public void PermMissingElem_ShouldReturn2_WhenNumberIs1(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 2 }, 1)]
        public void PermMissingElem_ShouldReturn1_WhenNumberIs2(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, 3)]
        public void PermMissingElem_DoubleRight(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 2, 3 }, 1)]
        public void PermMissingElem_DoubleLeft(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { }, 1)]
        public void PermMissingElem_0(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        public void PermMissingElem_100000()
        {
            var expected = 100001;
            int[] A = new int[100000];

            for (int i = 0; i < 100000; i++)
            {
                A[i] = i + 1;
            }

            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = PermMissingElem.Solution(A);

            // Assert
            actual.ShouldBeEquivalentTo(expected);
        }
    }
}
