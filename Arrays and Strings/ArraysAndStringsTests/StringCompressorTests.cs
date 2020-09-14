using ArraysAndStrings;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class StringCompressorTests
    {
        private readonly StringCompressor _stringCompressor = new StringCompressor();

        [Test]
        public void CompressReturnString()
        {
            Assert.IsInstanceOf(typeof(string), _stringCompressor.Compress("asd"));
        }

        [Test]
        public void CompressBasicWork()
        {
            Assert.AreEqual("a4", _stringCompressor.Compress("aaaa"));
        }

        [Test]
        public void CompressMoreCharWork()
        {
            Assert.AreEqual("a4b2c3d5", _stringCompressor.Compress("aaaabbcccddddd"));
        }
    }
}
