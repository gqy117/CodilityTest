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
