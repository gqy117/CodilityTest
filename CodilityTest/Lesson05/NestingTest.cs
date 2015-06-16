namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class NestingTest
    {
        [Test]
        [TestCase("(()(())())", 1)]
        [TestCase("())", 0)]
        public void Nesting_Default(string S, int expected)
        {
            ExecuteSolution(S, expected);
        }

        private static void ExecuteSolution(string S, int expected)
        {
            // Arrange

            // Act
            var actual = Nesting.Solution(S);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
