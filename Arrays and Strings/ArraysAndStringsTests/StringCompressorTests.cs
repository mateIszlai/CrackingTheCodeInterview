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
    }
}
