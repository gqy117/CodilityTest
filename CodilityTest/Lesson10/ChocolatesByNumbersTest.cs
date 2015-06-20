namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class ChocolatesByNumbersTest
    {
        [Test]
        [TestCase(10, 4, 5)]
        public void ChocolatesByNumbers_Default(int N, int M, int expected)
        {
            ExecuteSolution(N, M, expected);
        }

        [Test]
        [TestCase(1, 1, 1)]
        public void ChocolatesByNumbers_N1(int N, int M, int expected)
        {
            ExecuteSolution(N, M, expected);
        }

        [Test]
        [TestCase(1, 4, 1)]
        public void ChocolatesByNumbers_N1_M4(int N, int M, int expected)
        {
            ExecuteSolution(N, M, expected);
        }

        [Test]
        [TestCase(1, 1000000000, 1)]
        public void ChocolatesByNumbers_N1_MMax(int N, int M, int expected)
        {
            ExecuteSolution(N, M, expected);
        }

        [Test]
        [TestCase(1000000000, 1000000000, 1)]
        public void ChocolatesByNumbers_NMax_MMax(int N, int M, int expected)
        {
            ExecuteSolution(N, M, expected);
        }

        [Test]
        [TestCase(1000000000, 1, 1000000000)]
        public void ChocolatesByNumbers_NMax_M1(int N, int M, int expected)
        {
            ExecuteSolution(N, M, expected);
        }

        [Test]
        [TestCase(1000000000, 1000000000 - 1, 1000000000)]
        public void ChocolatesByNumbers_NMax_MMaxMinus1(int N, int M, int expected)
        {
            ExecuteSolution(N, M, expected);
        }

        [Test]
        [TestCase(10, 9, 10)]
        public void ChocolatesByNumbers_N10_M9(int N, int M, int expected)
        {
            ExecuteSolution(N, M, expected);
        }

        private static void ExecuteSolution(int N, int M, int expected)
        {
            // Arrange

            // Act
            var actual = ChocolatesByNumbers.Solution(N, M);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
