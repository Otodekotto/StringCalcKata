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
        public void Return3GivenStringWithComma1_2()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("1,2");

            Assert.Equal(3, result);
        }

        [Fact]
        public void Return13GivenStringWithMultipleComma1_2_5_5()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("1,2,5,5");

            Assert.Equal(13, result);
        }

        [Fact]
        public void Return6WithGivenInput1Delimitor2comma3()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("1\n2,3");

            Assert.Equal(6, result);
        }

        [Fact]
        public void Return3WithGivenInputDoubleSlashSemicolonDelimitor1Semicolon2()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("//;\n1;2");

            Assert.Equal(3, result);
        }

        [Fact]
        public void GivenNegativeNumberThrowException()
        {
            var calculator = new StringCalculator();

            Action action = () => calculator.Add("-1");

            var ex = Assert.Throws<Exception>(action);

            Assert.Equal("Negatives not allowed: -1", ex.Message);
        }


        [Fact]
        public void GivenMultipleNegativeNumberThrowException()
        {
            var calculator = new StringCalculator();

            Action action = () => calculator.Add("-1,6,-8");

            var ex = Assert.Throws<Exception>(action);

            Assert.Equal("Negatives not allowed: -1,-8", ex.Message);
        }

        [Fact]
        public void IgnoreNumberLargerThan1000()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("2,1001");

            Assert.Equal(2, result);
        }
    }
}
