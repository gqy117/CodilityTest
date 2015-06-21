namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class AbsDistinctTest
    {
        [Test]
        [TestCase(new int[] { -5, -3, -1, 0, 3, 6 }, 5)]
        public void ChocolatesByNumbers_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = AbsDistinct.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
