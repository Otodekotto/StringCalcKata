using System;
using Xunit;

namespace String_Calc_Kata.Tests
{
    public class StringCalcTest
    {
        [Fact]
        public void Return0GivenEmptyString()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");
            
            Assert.Equal(0, result);
        }

        [Fact]
        public void Return1GivenStringIs1()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("1");

            Assert.Equal(1, result);
        }

        [Fact]
        public void Return3GivenStringWithIs1Comma2()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("1,2");

            Assert.Equal(3, result);
        }
    }
}
