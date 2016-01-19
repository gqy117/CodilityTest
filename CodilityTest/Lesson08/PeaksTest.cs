namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [Ignore]
    public class PeaksTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3)]
        public void Peaks_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = Peaks.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
