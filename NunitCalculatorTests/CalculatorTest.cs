using NUnit.Framework;
using NunitCalculator;

namespace NunitCalculatorTests
{
    public class CalculatorTest
    {
        Calculator c = new Calculator();

        [TestCase(2,5,7)]
        public void AddNumbers_ShallReturnSum_ForTwoInt(int a, int b,int expected)
        {
            var actual=c.AddNumbers(a,b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 5, -3),Category("Skip")]
        public void SubstractNumbers_ShallReturnSubstraction_ForTwoInt(int a, int b, int expected)
        {
            var actual = c.SubstractNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, 10)]
        public void MultiplyNumbers_ShallReturnMultiplication_ForTwoInt(int a, int b, int expected)
        {
            var actual = c.MultiplyNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5, 2)]
        public void DivideNumbers_ShallReturnDivision_ForTwoInt(int a, int b, int expected)
        {
            var actual = c.DivideNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}
