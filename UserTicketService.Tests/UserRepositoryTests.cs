using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    public class UserRepositoryTests
    {
        //Выполните тестирование функции FindAll при помощи moq-объекта.
        //Используйте следующие три имени пользователей для добавления в moq-коллекцию:
        //Антон, Иван, Алексей.
        //При написании теста используйте фреймворк NUnit.
        //Для проверки наличия элемента в коллекции используйте метод That класса Assert и метод Any синтаксиса Linq.
        [Test]
        public void FindAllMustReturnCorrectValue()
        {
            var list = new List<User>
            {
                new User ()
                {Name = "Антон"},
                new User()
                {Name = "Иван"},
                new User()
                {Name = "Алексей"},
            };
            Mock <IUserRepository> mock = new Mock<IUserRepository> ();

            mock.Setup (v => v.FindAll()).Returns (list);

            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mock.Object.FindAll().Any(user => user.Name == "Алексей"));
        }
    }
}
