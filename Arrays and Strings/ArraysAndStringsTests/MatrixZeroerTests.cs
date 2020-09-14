using NUnit.Framework;
using ArraysAndStrings;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class MatrixZeroerTests
    {
        private readonly MatrixZeroer _matrixZeroer = new MatrixZeroer();

        [Test]
        public void AddZerosReturnMatrix()
        {
            var matrix = new int[5][];
            var actual = _matrixZeroer.AddZeros(matrix);
            Assert.IsInstanceOf(typeof(int[][]), actual);
        }

        [Test]
        public void AddZerosReturnSameLength()
        {
            var matrix = new int[5][];
            for(int i = 0; i < 5; i++)
            {
                matrix[i] = new int[4];
            }
            var actual = _matrixZeroer.AddZeros(matrix);
            Assert.That(matrix.Length == actual.Length && matrix[0].Length == actual[0].Length);
        }

        [Test]
        public void AddZerosAddingZeros()
        {
            var matrix = new int[][]
            {
                new int[]{1, 12, 3, 4},
                new int[]{1, 2, 0, 4},
                new int[]{1, 2, 35, 4},
                new int[]{12, 24, 3, 48},
                new int[]{0, 2, 30, 4}
            };

            var expected = new int[][]
            {
                new int[]{0, 12, 0, 4},
                new int[]{0, 0, 0, 0},
                new int[]{0, 2, 0, 4},
                new int[]{0, 24, 0, 48},
                new int[]{0, 0, 0, 0}
            };

            Assert.AreEqual(expected, _matrixZeroer.AddZeros(matrix));
        }

        [Test]
        public void AddZerosAddingZeros1()
        {
            var matrix = new int[][]
            {
                new int[]{15, 12, 3, 4},
                new int[]{1, 2, 5, 4},
                new int[]{1, 0, 35, 4},
                new int[]{14, 24, 3, 48},
                new int[]{24, 2, 30, 4}
            };

            var expected = new int[][]
            {
                new int[]{15, 0, 3, 4},
                new int[]{1, 0, 5, 4},
                new int[]{0, 0, 0, 0},
                new int[]{14, 0, 3, 48},
                new int[]{24, 0, 30, 4}
            };

            Assert.AreEqual(expected, _matrixZeroer.AddZeros(matrix));
        }
    }
}
