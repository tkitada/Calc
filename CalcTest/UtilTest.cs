using Calc.Domain;
using System;
using Xunit;

namespace CalcTest
{
    public class UtilTest
    {
        [Fact]
        public void GetDigitTest()
        {
            Assert.Equal(0, Util.GetDigit(0));
            Assert.Equal(1, Util.GetDigit(1));
            Assert.Equal(2, Util.GetDigit(12));
            Assert.Equal(3, Util.GetDigit(123));
            Assert.Equal(4, Util.GetDigit(1234));
            Assert.Equal(4, Util.GetDigit(01234));
        }
    }
}
