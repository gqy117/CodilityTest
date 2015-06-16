namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class FishTest
    {
        [Test]
        [TestCase(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }, 2)]
        public void Fish_Default(int[] A, int[] B, int expected)
        {
            ExecuteSolution(A, B, expected);
        }

        [Test]
        [TestCase(new int[] { 1 }, new int[] { 0 }, 1)]
        [TestCase(new int[] { 1 }, new int[] { 1 }, 1)]
        public void Fish_N1(int[] A, int[] B, int expected)
        {
            ExecuteSolution(A, B, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 1 }, 2)]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 0 }, 1)]
        [TestCase(new int[] { 1, 2 }, new int[] { 1, 1 }, 2)]
        [TestCase(new int[] { 1, 2 }, new int[] { 0, 0 }, 2)]
        [TestCase(new int[] { 2, 1 }, new int[] { 1, 0 }, 1)]
        [TestCase(new int[] { 2, 1 }, new int[] { 0, 1 }, 2)]
        [TestCase(new int[] { 2, 1 }, new int[] { 1, 1 }, 2)]
        [TestCase(new int[] { 2, 1 }, new int[] { 0, 0 }, 2)]
        public void Fish_N2(int[] A, int[] B, int expected)
        {
            ExecuteSolution(A, B, expected);
        }

        private static void ExecuteSolution(int[] A, int[] B, int expected)
        {
            // Arrange

            // Act
            var actual = Fish.Solution(A, B);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
