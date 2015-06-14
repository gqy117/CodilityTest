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
            4)
        ]
        public void NailingPlanks_Default(int[] A, int[] B, int[] C, int expected)
        {
            ExecuteSolution(A, B, C, expected);
        }

        [Test]
        [TestCase(
            new int[] { 1, 4, 5 },
            new int[] { 4, 5, 9 },
            new int[] { 4, 6, 7, 10, 2 },
            2)
        ]
        public void NailingPlanks_2(int[] A, int[] B, int[] C, int expected)
        {
            ExecuteSolution(A, B, C, expected);
        }

        [Test]
        [TestCase(
            new int[] { 1, 5, 7 },
            new int[] { 4, 6, 9 },
            new int[] { 4, 7, 8, 10, 2 },
            -1)
        ]
        public void NailingPlanks_NotPossible2(int[] A, int[] B, int[] C, int expected)
        {
            ExecuteSolution(A, B, C, expected);
        }

        [Test]
        [TestCase(
            new int[] { 1, 5, 8 },
            new int[] { 4, 6, 9 },
            new int[] { 4, 7 },
            -1)
        ]
        public void NailingPlanks_NotEnoughNails(int[] A, int[] B, int[] C, int expected)
        {
            ExecuteSolution(A, B, C, expected);
        }

        [Test]
        [TestCase(
            new int[] { 1, 5, 20 },
            new int[] { 4, 6, 21 },
            new int[] { 4, 7, 8, 9, 10, 11, 12, 20 },
            -1)
        ]
        public void NailingPlanks_WastedALotOfNails(int[] A, int[] B, int[] C, int expected)
        {
            ExecuteSolution(A, B, C, expected);
        }

        [Test]
        [TestCase(
            new int[] { 1 },
            new int[] { 4 },
            new int[] { 5 },
            -1)
        ]
        public void NailingPlanks_NotPossible(int[] A, int[] B, int[] C, int expected)
        {
            ExecuteSolution(A, B, C, expected);
        }

        [Test]
        [TestCase(
            new int[] { 1 },
            new int[] { 4 },
            new int[] { 3, 5 },
            1)
        ]
        public void NailingPlanks_OneNumberPossible(int[] A, int[] B, int[] C, int expected)
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
