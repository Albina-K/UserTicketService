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
            var calculator = new Calculator();

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

        [Test]
        public void Subtraction_MustReturnCorrectValue2()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(300, 10) == 290);
        }
    }
}
