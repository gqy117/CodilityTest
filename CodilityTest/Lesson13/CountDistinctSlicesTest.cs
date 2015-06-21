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
