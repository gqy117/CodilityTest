namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class MaxProfitTest
    {
        [Test]
        [TestCase(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }, 356)]
        public void MaxProfit_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { }, 0)]
        public void MaxProfit_N0(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1 }, 0)]
        public void MaxProfit_N1(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, 1)]
        [TestCase(new int[] { 2, 1 }, 0)]
        public void MaxProfit_N2(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 2)]
        [TestCase(new int[] { 2, 1, 3 }, 2)]
        public void MaxProfit_N3(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = MaxProfit.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
