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
    public class FrogJmpTest
    {
        [Test]
        [TestCase(10, 85, 30, 3)]
        public void FrogJmp_Default(int X, int Y, int D, int expected)
        {
            ExecuteSolution(X, Y, D, expected);
        }

        [Test]
        [TestCase(10, 10, 30, 0)]
        public void FrogJmp_XEqualsY(int X, int Y, int D, int expected)
        {
            ExecuteSolution(X, Y, D, expected);
        }

        [Test]
        [TestCase(1, 1000000000, 1, 999999999)]
        public void FrogJmp_XMin_YMax(int X, int Y, int D, int expected)
        {
            ExecuteSolution(X, Y, D, expected);
        }

        [Test]
        [TestCase(1, 1, 1, 0)]
        public void FrogJmp_XMin_YMin(int X, int Y, int D, int expected)
        {
            ExecuteSolution(X, Y, D, expected);
        }

        [Test]
        [TestCase(1000000000, 1000000000, 1, 0)]
        public void FrogJmp_XMax_YMax(int X, int Y, int D, int expected)
        {
            ExecuteSolution(X, Y, D, expected);
        }

        private static void ExecuteSolution(int X, int Y, int D, int expected)
        {
            // Arrange

            // Act
            var actual = FrogJmp.Solution(X, Y, D);

            // Assert
            Assert.AreEqual(expected, actual);;
        }
    }
}
