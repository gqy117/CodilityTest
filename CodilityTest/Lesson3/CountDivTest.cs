namespace CodilityTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Codility;
    using NUnit.Framework;

    [TestFixture]
    public class CountDivTest
    {
        [Test]
        [TestCase(6, 11, 2, 3)]
        [TestCase(6, 12, 2, 4)]
        [TestCase(6, 13, 2, 4)]
        [TestCase(6, 14, 2, 5)]
        public void MaxCounters_Default(int A, int B, int K, int expected)
        {
            ExecuteSolution(A, B, K, expected);
        }

        [Test]
        [TestCase(3, 10, 2, 4)]
        public void MaxCounters_From3To10_K2(int A, int B, int K, int expected)
        {
            ExecuteSolution(A, B, K, expected);
        }

        [Test]
        [TestCase(0, 0, 1, 1)]
        [TestCase(2000000000, 2000000000, 1, 1)]
        [TestCase(0, 2000000000, 1, 2000000001)]
        public void MaxCounters_A_B_Max_Min(int A, int B, int K, int expected)
        {
            ExecuteSolution(A, B, K, expected);
        }

        private static void ExecuteSolution(int A, int B, int K, int expected)
        {
            // Arrange

            // Act
            var actual = CountDiv.Solution(A, B, K);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
