namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class NailingPlanksTest
    {
        [Test]
        [TestCase(
            new int[] { 1, 4, 5, 8 }, 
            new int[] { 4, 5, 9, 10 }, 
            new int[] { 4, 6, 7, 10, 2 }, 
            4)]
        public void NailingPlanks_Default(int[] A, int[] B, int[] C, int expected)
        {
            ExecuteSolution(A, B, C, expected);
        }

        private static void ExecuteSolution(int[] A, int[] B, int[] C, int expected)
        {
            // Arrange

            // Act
            var actual = NailingPlanks.Solution(A, B, C);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
