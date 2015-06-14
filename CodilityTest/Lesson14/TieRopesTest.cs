namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class TieRopesTest
    {
        [Test]
        [TestCase(4, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 3)]
        public void MaxNonoverlappingSegments_Default(int K, int[] A, int expected)
        {
            ExecuteSolution(K, A, expected);
        }

        [Test]
        [TestCase(1, new int[] { 1 }, 1)]
        [TestCase(2, new int[] { 1 }, 0)]
        [TestCase(1, new int[] { 2 }, 1)]
        public void MaxNonoverlappingSegments_N1_K1(int K, int[] A, int expected)
        {
            ExecuteSolution(K, A, expected);
        }

        [Test]
        [TestCase(1000000000, new int[] { 1 }, 0)]
        [TestCase(1000000000, new int[] { 1000000000 }, 1)]
        public void MaxNonoverlappingSegments_N1_KMax(int K, int[] A, int expected)
        {
            ExecuteSolution(K, A, expected);
        }

        private static void ExecuteSolution(int K, int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = TieRopes.Solution(K, A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
