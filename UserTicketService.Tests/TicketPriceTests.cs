using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    public class TicketPriceTests
    {
        [Test]
        public void TicketPriceMustReturnNotNullableTicket()
        {
            var mockTicketService = new Mock <ITicketService>();//Данной строкой мы создали moq-объект с типом ITicketService:
            //Данные строки выполняют конфигурацию нашего объекта moq.
            //Конкретнее, они устанавливают возвращаемое значение при определенных запросах:
            mockTicketService.Setup(p => p.GetTicketPrice(1)).Returns(100);
            mockTicketService.Setup(p => p.GetTicketPrice(2)).Returns(500);
            mockTicketService.Setup(p => p.GetTicketPrice(3)).Returns(7800);
           // Используя moq-объекты, мы выполнили тестирование нашего кода без использования рабочего бэкенда.
           
            var ticketPriceTest = new TicketPrice(mockTicketService.Object);
            Assert.That(ticketPriceTest.MakeTicketPrice(3) == 7800);
        }
    }
}
