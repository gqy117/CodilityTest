namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class MaxDoubleSliceSumTest
    {
        [Test]
        [TestCase(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17)]
        public void MaxDoubleSliceSum_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, -1000, 1, 1, 1, -1000, 1 }, 3)]
        [TestCase(new int[] { 1, -1000, 1, -1, 1, -1000, 1 }, 2)]
        [TestCase(new int[] { 1, -1000, 1, -1, -1000, 1, -1000, 1 }, 1)]
        public void MaxDoubleSliceSum_BigNegativeInTheMiddle(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 1, 1, 1 }, 0)]
        [TestCase(new int[] { 3, 2, 1 }, 0)]
        [TestCase(new int[] { 10000, 10000, 10000 }, 0)]
        [TestCase(new int[] { -10000, -10000, -10000 }, 0)]
        public void MaxDoubleSliceSum_N3(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = MaxDoubleSliceSum.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
