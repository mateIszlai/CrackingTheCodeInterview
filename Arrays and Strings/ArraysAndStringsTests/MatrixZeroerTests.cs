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
    }
}
