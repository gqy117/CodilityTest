namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class DistinctTest
    {
        [Test]
        [TestCase(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]
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
