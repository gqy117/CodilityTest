namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class EquiLeaderTest
    {
        [Test]
        [TestCase(new int[] { 4, 3, 4, 4, 4, 2 }, 2)]
        public void EquiLeader_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = EquiLeader.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
