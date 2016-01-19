namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    [Ignore]
    public class MinMaxDivisionTest
    {
        [Test]
        [TestCase(3, 5, new int[] { 2, 1, 5, 1, 2, 2, 2 }, 6)]
        public void MinMaxDivision_Default(int K, int M, int[] A, int expected)
        {
            ExecuteSolution(K, M, A, expected);
        }

        private static void ExecuteSolution(int K, int M, int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = MinMaxDivision.Solution(K, M, A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
