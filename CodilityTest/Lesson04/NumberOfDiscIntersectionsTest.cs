namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class NumberOfDiscIntersectionsTest
    {
        [Test]
        [TestCase(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        public void NumberOfDiscIntersections_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 4 }, 0)]
        public void NumberOfDiscIntersections_N1(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        public void NumberOfDiscIntersections_RandomSmall(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 0, 2147483647, 0 }, 2)]
        public void NumberOfDiscIntersections_BigNumber(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = NumberOfDiscIntersections.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
