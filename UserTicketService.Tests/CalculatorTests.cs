using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void MultiplicationMustReturnNotNullValue()//ДействиеДолженОжидаемое возвращаемое значение
        {
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(v => v.Send()).Returns(true);
            
            var calculator = new Calculator(mockMailSender.Object);

            Assert.AreEqual(8, calculator.Multiplication(2, 4));
        }

      //  Напишите тест для функции Subtraction.При написании теста, используйте фреймворк NUnit.


        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator2 calculator = new Calculator2();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        // Напишите тест для функции Division, проверяющий исключение
        // DivideByZeroException при попытке деления числа на ноль.
        // При написании теста используйте фреймворк NUnit.

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator3();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        //[Test]
        //public void Subtraction_MustReturnCorrectValue2()
        //{
        //    Calculator calculator = new Calculator();
        //    Assert.True(calculator.Subtraction(300, 10) == 290);
        //}

        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator4();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Addition(50, 10, 34);
            Assert.Equals(94, result);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.Equals(120, result);
        }
    }
}
