namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class StoneWallTest
    {
        [Test]
        [TestCase(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 }, 7)]
        public void StoneWall_Default(int[] H, int expected)
        {
            ExecuteSolution(H, expected);
        }

        private static void ExecuteSolution(int[] H, int expected)
        {
            // Arrange

            // Act
            var actual = StoneWall.Solution(H);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
