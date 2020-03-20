using NUnit.Framework;
using TwoDArraySolution;

namespace TwoDArrayTests
{
    public class HourGlassSumTests
    {
        int[][] _firstCase;
        int[][] _secondCase;
        private TwoDArray _solution;

        [SetUp]
        public void Setup()
        {
            // -9 -9 -9 1 1 1
            // 0 -9 0 4 3 2
            // -9 -9 -9 1 2 3
            // 0 0 8 6 6 0
            // 0 0 0 -2 0 0
            // 0 0 1 2 4 0
            _firstCase = new int[][]
            {
                new int[] {-9, -9, -9, 1, 1, 1}, 
                new int[] {0, -9, 0, 4, 3, 2}, 
                new int[] {-9, -9, -9, 1, 2, 3},
                new int[] {0, 0, 8, 6, 6, 0}, 
                new int[] {0, 0, 0, -2, 0, 0}, 
                new int[] {0, 0, 1, 2, 4, 0}
            };
            _solution = new TwoDArray();

            // -1 -1 0 -9 -2 -2
            // -2 ,-1 ,-6, -8, -2, -5
            // -1 ,-1 ,-1, -2, -3, -4
            // -1 ,-9 ,-2, -4, -4, -5
            // -7 ,-3 ,-3, -2, -9, -9
            // -1 ,-3 ,-1, -2, -4, -5
            _secondCase = new int[][]
            {
                new[] {-1, -1, 0, -9, -2, -2},
                new[] {-2, -1, -6, -8, -2, -5},
                new[] {-1, -1, -1, -2, -3, -4},
                new[] {-1, -9, -2, -4, -4, -5},
                new[] {-7, -3, -3, -2, -9, -9},
                new[] {-1, -3, -1, -2, -4, -5},
                new[] {-1, -1, 0, -9, -2, -2}
            };
        }

        [Test]
        public void Solution1_ShouldReturn_TwentyEight()
        {
            //Arrange
            int expected = 28;
            //Act
            var actual = _solution.HourGlassSumSolution1(_firstCase);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Solution1_ShouldReturn_MinusSix()
        {
            //Arrange
            int expected = -6;
            //Act
            var actual = _solution.HourGlassSumSolution1(_secondCase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}