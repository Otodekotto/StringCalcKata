using System;
using Xunit;

namespace String_Calc_Kata.Tests
{
    public class StringCalcTest
    {
        [Fact]
        public void Returnt0GivenEmptyString()
        {
            var calculator = new StringCalc();

            var result = calculator.Add("");
            
            Assert.Equal(0, result);
        }
    }
}
