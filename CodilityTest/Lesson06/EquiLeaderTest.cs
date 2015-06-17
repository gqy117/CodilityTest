﻿namespace CodilityTest
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
