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
