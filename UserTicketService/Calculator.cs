using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService
{
    public class Calculator
    {
        IMailSender mailSender;
        public Calculator(IMailSender mailSender)
        {
            this.mailSender = mailSender;
        }
        public int Multiplication(int a, int b)
        {
            this.mailSender.Send();
            return a * b;
        }

        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }


    }
    // Напишите тест для функции Subtraction.При написании теста, используйте фреймворк NUnit.
    public class Calculator2
    {
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }

    public class Calculator3
    {
        public int Division(int a, int b)
        {
            return a / b;
        }
    }

    public class Calculator4
    {
        public int Add(int one, int two)
        {
            return one + two;
        }
    }
}
