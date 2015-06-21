namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class AbsDistinctTest
    {
        [Test]
        [TestCase(new int[] { -5, -3, -1, 0, 3, 6 }, 5)]
        public void AbsDistinct_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { int.MaxValue }, 1)]
        public void AbsDistinct_N1(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { int.MinValue }, 1)]
        public void AbsDistinct_Min(int[] A, int expected)
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
