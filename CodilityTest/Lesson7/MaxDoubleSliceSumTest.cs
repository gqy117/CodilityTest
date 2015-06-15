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
