namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class CountSemiprimesTest
    {
        [Test]
        [TestCase(26, new int[] { 1, 4, 16 }, new int[] { 26, 10, 20 }, new int[] { 10, 0, 4 })]
        public void CountSemiprimes_Default(int N, int[] P, int[] Q, int expected)
        {
            ExecuteSolution(N, P, Q, expected);
        }

        private static void ExecuteSolution(int N, int[] P, int[] Q, int expected)
        {
            // Arrange

            // Act
            var actual = CountSemiprimes.Solution(N, P, Q);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
