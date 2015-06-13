namespace CodilityTest
{
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class PassingCarsTest
    {
        [Test]
        [TestCase(new int[] { 0, 1, 0, 1, 1 }, 5)]
        public void MaxCounters_Default(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 0, 1, 0, 0 }, 5)]
        public void MaxCounters_1First(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 0, 1 }, 1)]
        public void MaxCounters_3Pairs(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 0, 1, 0 }, 3)]
        public void MaxCounters_4Pairs(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1, 1 }, 0)]
        [TestCase(new int[] { 0, 0 }, 0)]
        [TestCase(new int[] { 0, 1 }, 1)]
        [TestCase(new int[] { 1, 0 }, 1)]
        public void MaxCounters_Double(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 0 }, 0)]
        public void MaxCounters_Single(int[] A, int expected)
        {
            ExecuteSolution(A, expected);
        }

        [Test]
        [TestCase(100000, -1)]
        public void MaxCounters_N100000(int N, int expected)
        {
            int[] A = new int[100000];
            int zeroOrOne = 0;

            for (int i = 0; i < N; i++)
            {
                A[i] = zeroOrOne;

                zeroOrOne = zeroOrOne == 0 ? 1 : 0;
            }

            ExecuteSolution(A, expected);
        }

        private static void ExecuteSolution(int[] A, int expected)
        {
            // Arrange

            // Act
            var actual = PassingCars.Solution(A);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
