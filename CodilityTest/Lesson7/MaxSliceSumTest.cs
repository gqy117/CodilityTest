namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class MaxSliceSumTest
    {
        [Test]
        [TestCase(new int[] { 3, 2, -6, 4, 0 }, 5)]
        public void MaxSliceSum_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = MaxSliceSum.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
