using Xunit;

namespace XUnitTestProject1
{
    public class StringUtilsTests
    {
        private readonly StringUtils _stringUtils;

        public StringUtilsTests()
        {
            _stringUtils = new StringUtils();
        }       

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("    ", false)]
        [InlineData("Not a palindrome", false)]
        [InlineData("kayak", true)]
        [InlineData("Kayak", true)]
        [InlineData("Able was I ere I saw Elba", true)]
        [InlineData("%@%", true)]
        [InlineData("шалаш", true)]
        public void PalindromeTest(string value, bool expected)
        {
            var actual = _stringUtils.IsMirrorSequence(value);
            Assert.Equal(actual, expected);
        }
    }
}
