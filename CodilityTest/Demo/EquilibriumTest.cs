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
    public class EquilibriumTest
    {
        [Test]
        [TestCase(new int[] { -1, 3, -4, 5, 1, -6, 2, 1 }, 1)]
        public void Equilibrium_Default(int[] a, int expected)
        {
            ExecuteSolution(a, expected);
        }

        [Test]
        [TestCase(new int[] { -2147483648 }, 0)]
        public void Equilibrium_BigNegativeNumber(int[] a, int expected)
        {
            ExecuteSolution(a, expected);
        }

        [Test]
        [TestCase(new int[] { 500, 1, -2, -1, 2 }, 0)]
        public void Equilibrium_LeftFirst(int[] a, int expected)
        {
            ExecuteSolution(a, expected);
        }

        [Test]
        [TestCase(new int[] { 2147483647, 2147483647, 0, 2147483647, 2147483647 }, 2)]
        public void Equilibrium_BigPositiveNumber(int[] a, int expected)
        {
            ExecuteSolution(a, expected);
        }

        private static void ExecuteSolution(int[] a, int expected)
        {
            // Arrange

            // Act
            var actual = Equilibrium.Solution(a);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
