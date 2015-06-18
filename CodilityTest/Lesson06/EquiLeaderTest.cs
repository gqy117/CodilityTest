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

        [Test]
        [TestCase(new int[] { 1 }, 0)]
        public void EquiLeader_N1(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2 }, 0)]
        [TestCase(new int[] { 1, 1 }, 1)]
        public void EquiLeader_N2(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 0)]
        [TestCase(new int[] { 1, 1, 1 }, 2)]
        public void EquiLeader_N3(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 2, 1, 1, 1, 3 }, 0)]
        public void EquiLeader_Middle3(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 2, 1, 1, 1, 1, 3 }, 1)]
        [TestCase(new int[] { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3 }, 7)]
        public void EquiLeader_LeaderInTheMiddle(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(205, 200)]
        [TestCase(305, 300)]
        public void EquiLeader_NIsLarge(int N, int expected)
        {
            int[] A = new int[N];
            A[0] = 2;
            A[N - 1] = 3;

            for (int i = 1; i < N - 1; i++)
            {
                A[i] = -1000000000;
            }

            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 2, 3, 0, 0, 0, 0, 0, 100, 101, 102 }, 0)]
        public void EquiLeader_Middle00000(int[] A, int expected)
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
