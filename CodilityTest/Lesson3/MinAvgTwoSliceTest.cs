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
        [TestCase(4, 2, 2, 5, 1, 5, 8, 1)]
        public void MaxCounters_Default(int[] A, int expected)
        {
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
