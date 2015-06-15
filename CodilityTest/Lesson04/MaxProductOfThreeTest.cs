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

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, 6)]
        [TestCase(new int[] { -1000, -1000, -1000 }, -1000000000)]
        [TestCase(new int[] { 1000, 1000, 1000 }, 1000000000)]
        public void MaxProductOfThree_N3(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { -1000, -1, 1, 2, 3 }, 3000)]
        public void MaxProductOfThree_NegativeAndPositive(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, 1000, 1000000000)]
        [TestCase(100000, -1000, -1000000000)]
        public void MaxProductOfThree_N100000_AMaxMin(int N, int AValue, int expected)
        {
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = AValue;
            }

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
