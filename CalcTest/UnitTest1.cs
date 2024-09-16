using NUnit.Framework;
using Calc;

namespace Calc.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            double result = _calculator.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
        {
            double result = _calculator.Subtract(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_ShouldReturnProductOfTwoNumbers()
        {
            double result = _calculator.Multiply(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Divide_ShouldReturnQuotientOfTwoNumbers()
        {
            double result = _calculator.Divide(6, 3);
            Assert.That(result, Is.EqualTo(2));
        }


        [Test]
        public void Power_ShouldReturnPowerOfNumber()
        {
            double result = _calculator.Power(2, 3);
            Assert.That(result, Is.EqualTo(8));
        }
    }
}