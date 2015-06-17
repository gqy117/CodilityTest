namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class BracketsTest
    {
        [Test]
        [TestCase("{[()()]}", 1)]
        [TestCase("([)()]", 0)]
        public void Brackets_Default(string S, int expected)
        {
            ExecuteSolution(S, expected);
        }

        [Test]
        [TestCase("(([]))", 1)]
        [TestCase("({)}", 0)]
        [TestCase("{(())}", 1)]
        public void Brackets_SmallBracketOnTheRightOfLargeBracket(string S, int expected)
        {
            ExecuteSolution(S, expected);
        }

        [Test]
        [TestCase("((", 0)]
        public void Brackets_AllLeftBrackets(string S, int expected)
        {
            ExecuteSolution(S, expected);
        }

        [Test]
        [TestCase("", 1)]
        public void Brackets_Empty(string S, int expected)
        {
            ExecuteSolution(S, expected);
        }

        private static void ExecuteSolution(string S, int expected)
        {
            // Arrange

            // Act
            var actual = Brackets.Solution(S);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
