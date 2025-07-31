using RunLengthEncoding;

namespace RLEUnitTest
{
    public class RLEUnitTest1
    {
        [Theory]
        [InlineData("aabbcc", "a2b2c2")]
        [InlineData(null, "")]
        [InlineData("abc", "a1b1c1")]
        public void RLEEncodingTest(string input, string output)
        {
            string result = RunLengthEncoder.Encode(input);
            Assert.Equal(output, result);
        }
    }
}