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

        [Test]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 1, 2 }, 0)]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        public void Triangle_N01234(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 2147483645, 2147483646, 2147483647 }, 1)]
        public void Triangle_AMax(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { -2147483645, -2147483646, -2147483647 }, 0)]
        public void Triangle_AMin(int[] A, int expected)
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