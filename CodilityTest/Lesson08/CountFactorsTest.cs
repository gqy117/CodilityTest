namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class CountFactorsTest
    {
        [Test]
        [TestCase(24, 8)]
        public void CountFactors_Default(int N, int expected)
        {
            ExecuteSolution(N, expected);
        }

        private static void ExecuteSolution(int N, int expected)
        {
            // Arrange

            // Act
            var actual = CountFactors.Solution(N);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
