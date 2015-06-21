namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class CountDistinctSlicesTest
    {
        [Test]
        [TestCase(6, new int[] { 3, 4, 5, 5, 2 }, 9)]
        public void CountDistinctSlices_Default(int M, int[] A, int expected)
        {
            ExecuteSolution(M, A, expected);
        }

        [Test]
        [TestCase(6, new int[] { 1 }, 1)]
        public void CountDistinctSlices_N1(int M, int[] A, int expected)
        {
            ExecuteSolution(M, A, expected);
        }

        [Test]
        [TestCase(6, new int[] { 1, 2 }, 3)]
        public void CountDistinctSlices_N2(int M, int[] A, int expected)
        {
            ExecuteSolution(M, A, expected);
        }

        [Test]
        [TestCase(6, new int[] { 2, 2 }, 2)]
        public void CountDistinctSlices_N2_SameValue(int M, int[] A, int expected)
        {
            ExecuteSolution(M, A, expected);
        }

        [Test]
        [TestCase(6, new int[] { 1, 2, 1 }, 5)]
        public void CountDistinctSlices_N3(int M, int[] A, int expected)
        {
            ExecuteSolution(M, A, expected);
        }

        [Test]
        [TestCase(6, new int[] { 1, 2, 2, 1 }, 6)]
        public void CountDistinctSlices_N4(int M, int[] A, int expected)
        {
            ExecuteSolution(M, A, expected);
        }

        [Test]
        [TestCase(6, new int[] { 1, 2, 3, 2, 1 }, 11)]
        public void CountDistinctSlices_N5(int M, int[] A, int expected)
        {
            ExecuteSolution(M, A, expected);
        }

        private static void ExecuteSolution(int M, int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = CountDistinctSlices.Solution(M, A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
