namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class NumberOfDiscIntersectionsTest
    {
        [Test]
        [TestCase(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        public void MaxCounters_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = NumberOfDiscIntersections.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
