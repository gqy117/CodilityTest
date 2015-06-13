namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class PassingCarsTest
    {
        [Test]
        [TestCase(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1)]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 3, 2, 1 }, 1)]
        [TestCase(new int[] { 1, 2, 9, 1, 2, 1 }, 3)]
        public void MaxCounters_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = PassingCars.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
