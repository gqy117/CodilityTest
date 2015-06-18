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

        [Test]
        [TestCase(16, 5)]
        public void CountFactors_16(int N, int expected)
        {
            ExecuteSolution(N, expected);
        }

        [Test]
        [TestCase(1, 1)]
        public void CountFactors_1(int N, int expected)
        {
            ExecuteSolution(N, expected);
        }

        [Test]
        [TestCase(2, 2)]
        public void CountFactors_2(int N, int expected)
        {
            ExecuteSolution(N, expected);
        }

        [Test]
        [TestCase(7, 2)]
        public void CountFactors_7(int N, int expected)
        {
            ExecuteSolution(N, expected);
        }

        [Test]
        [TestCase(69, 4)]
        public void CountFactors_69(int N, int expected)
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
