namespace CodilityTest
{
    using System.Linq;
    using Codility;
    using NUnit.Framework;

    public class DominatorTest
    {
        [Test]
        [TestCase(new int[] { 3, 4, 3, 2, 3 - 1, 3, 3 }, new int[] { 0, 2, 4, 6, 7 })]
        public void Dominator_Default(int[] A, int[] expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int[] expected)
        {
            // Arrange

            // Act
            var actual = Dominator.Solution(A);

            // Assert
            Assert.IsTrue(expected.Contains(actual));
        }
    }
}
