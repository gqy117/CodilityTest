namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class MinPerimeterRectangleTest
    {
        [Test]
        [TestCase(30, 22)]
        public void MinPerimeterRectangle_Default(int N, int expected)
        {
            ExecuteSolution(N, expected);
        }

        private static void ExecuteSolution(int N, int expected)
        {
            // Arrange

            // Act
            var actual = MinPerimeterRectangle.Solution(N);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
