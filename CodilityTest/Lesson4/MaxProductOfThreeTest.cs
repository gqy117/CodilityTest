namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class MaxProductOfThreeTest
    {
        [Test]
        [TestCase(new int[] { -3, 1, 2, -2, 5, 6 }, 60)]
        public void MaxProductOfThree_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = MaxProductOfThree.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
