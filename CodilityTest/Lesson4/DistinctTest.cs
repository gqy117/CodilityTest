namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class DistinctTest
    {
        [Test]
        [TestCase(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        public void DistinctTest_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = Distinct.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
