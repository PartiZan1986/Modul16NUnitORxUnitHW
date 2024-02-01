using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Additional_MustReturnValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(10, 20) == 30);
        }

        [Test]
        public void Subtraction_MustReturnValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(20, 10) == 10);
        }

        [Test]
        public void Multiplication_MustReturnValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(20, 10) == 200);
        }

        [Test]
        public void Division_MustReturnValue()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(20, 0));
        }
    }   
}
