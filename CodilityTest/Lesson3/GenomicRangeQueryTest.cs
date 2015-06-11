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
    public class GenomicRangeQueryTest
    {
        [Test]
        [TestCase("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }, 1)]
        public void MaxCounters_Default(string S, int[] P, int[] Q, int expected)
        {
            ExecuteSolution(S, P, Q, expected);
        }

        private static void ExecuteSolution(string S, int[] P, int[] Q, int expected)
        {
            // Arrange

            // Act
            var actual = GenomicRangeQuery.Solution(S, P, Q);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
