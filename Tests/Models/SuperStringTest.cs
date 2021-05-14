using Src.Models;
using Xunit;

namespace Tests.Models
{
    public class SuperStringTest
    {
        [Fact]
        public void Should_Return_ZigZag_String()
        {
            var str = "PAYPALISHIRING";
            var rows = 3;

            string result = SuperString.ConvertToZigZag(str, rows);

            Assert.True(string.Equals(result, "PAHNAPLSIIGYIR"));
        }
    }
}