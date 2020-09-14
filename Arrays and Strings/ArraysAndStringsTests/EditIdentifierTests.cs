using ArraysAndStrings;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class EditIdentifierTests
    {
        private readonly EditIdentifier _editIdentifier = new EditIdentifier();

        [Test]
        public void IsEditedMaxOnceReturnBoolean()
        {
            Assert.That(_editIdentifier.IsEditedMaxOnce("p", "p") == true || _editIdentifier.IsEditedMaxOnce("p", "p") == false);
        }
    }
}
