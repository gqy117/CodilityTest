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

        [Test]
        [TestCase(1, 4)]
        public void MinPerimeterRectangle_N1(int N, int expected)
        {
            ExecuteSolution(N, expected);
        }

        [Test]
        [TestCase(2, 6)]
        public void MinPerimeterRectangle_N2(int N, int expected)
        {
            ExecuteSolution(N, expected);
        }

        [Test]
        [TestCase(3, 8)]
        public void MinPerimeterRectangle_N3(int N, int expected)
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
