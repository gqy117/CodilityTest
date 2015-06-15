namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    public class DistinctTest
    {
        [Test]
        [TestCase(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]
        public void DistinctTest_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { }, 0)]
        public void DistinctTest_N0(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 100000)]
        public void DistinctTest_N100000_AEqualsI(int N, int expected)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = i;
            }

            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 1)]
        public void DistinctTest_N100000_AMax(int N, int expected)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = 1000000;
            }

            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 1)]
        public void DistinctTest_N100000_AMin(int N, int expected)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = -1000000;
            }

            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = Distinct.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
