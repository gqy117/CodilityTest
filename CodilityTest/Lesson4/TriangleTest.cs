namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class TriangleTest
    {
        [Test]
        [TestCase(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [TestCase(new int[] { 10, 2, 5, 1 }, 0)]
        public void Triangle_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = Triangle.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}