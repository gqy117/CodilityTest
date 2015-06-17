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

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { -1 })]
        public void Dominator_NoLeader(int[] A, int[] expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 1, 1, 1, 4, 5, 6 }, new int[] { 0 })]
        public void Dominator_LeaderAtTheBeginning(int[] A, int[] expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 1, 1, 4, 5, 6 }, new int[] { -1 })]
        public void Dominator_LeaderCandidateAppearsHalfOfTheArray(int[] A, int[] expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 4, 5, 6, 1, 1, 1, 1 }, new int[] { 3 })]
        public void Dominator_LeaderAtTheEnd(int[] A, int[] expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 4, 1, 5, 1, 6, 1 }, new int[] { 0 })]
        public void Dominator_LeaderInTheMiddle(int[] A, int[] expected)
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
