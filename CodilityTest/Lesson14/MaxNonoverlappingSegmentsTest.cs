namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class MaxNonoverlappingSegmentsTest
    {
        [Test]
        [TestCase(new int[] { 1, 3, 7, 9, 9 }, new int[] { 5, 6, 8, 9, 10 }, 3)]
        public void MaxNonoverlappingSegments_Default(int[] A, int[] B, int expected)
        {
            ExecuteSolution(A, B, expected);
        }

        private static void ExecuteSolution(int[] A, int[] B, int expected)
        {
            // Arrange

            // Act
            var actual = MaxNonoverlappingSegments.Solution(A, B);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
