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
    public class MaxCountersTest
    {
        [Test]
        [TestCase(10, 85, 30, 3)]
        public void MaxCounters_Default(int X, int Y, int D, int expected)
        {
            ExecuteSolution(X, Y, D, expected);
        }

        private static void ExecuteSolution(int X, int Y, int D, int expected)
        {
            // Arrange

            // Act
            var actual = MaxCounters.Solution(X, Y, D);

            // Assert
            actual.ShouldBeEquivalentTo(expected);
        }
    }
}
