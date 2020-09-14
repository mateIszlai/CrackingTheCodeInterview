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
    }
}
