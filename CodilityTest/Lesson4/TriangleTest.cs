namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class TriangleTest
    {
        [Test]
        [TestCase(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
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