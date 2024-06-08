using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp;

namespace ContactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        private Contact _contact;

        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
        }

        /// <summary>
        /// Позитивный тест геттера FullName
        /// </summary>
        [Test(Description = "Позитивный тест геттера FullName")]
        public void TestFullNameGet_CorrectValue()
        {
            // Arrange
            var expected = "Смирнов Андрей";
            _contact.FullName = expected;

            // Act
            var actual = _contact.FullName;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер FullName возвращает неправильную фамилию");
        }

        /// <summary>
        /// Негативный тест для проверки сеттера имени и фамилии
        /// </summary>
        /// <param name="wrongFullName">переменная FullName для теста</param>
        /// <param name="message">Сообщение при ошибки теста</param>
        [TestCase("", "Должно возникать исключение, если фамилия и имя - пустая строка",
        TestName = "Присвоение пустой строки в качестве фамилии и имени")]
        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов-Смирнов-Смирнов-Смирнов-Смирнов-СмирновСмирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов",
        "Должно возникать исключение, если фамилия и имя длиннее 100 символов",
        TestName = "Присвоение неправильной фамилии и имени больше 100 символов")]
        public void TestSurnameSet_ArgumentException(string wrongFullName, string
        message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.FullName = wrongFullName; },
            message);
        }

        /// <summary>
        /// Позитивный тест геттера PhoneNumber
        /// </summary>
        [Test(Description = "Позитивный тест геттера PhoneNumber")]
        public void TestPhoneNumberGet_CorrectValue()
        {
            // Arrange
            var expected = "9043769910";
            _contact.PhoneNumber = expected;

            // Act
            var actual = _contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер PhoneNumber возвращает неправильный номер телефона");
        }

        /// <summary>
        /// Негативный тест для проверки сеттера телефонного номера
        /// </summary>
        /// <param name="wrongPhoneNumber">переменная PhoneNumber для теста</param>
        /// <param name="message">Сообщение при ошибки теста</param>
        [TestCase("", "Должно возникать исключение, если телефон-пустая строка",
       TestName = "Присвоение пустой строки в качестве телефонного номера")]
        [TestCase("90430769910",
       "Должно возникать исключение, если телефон введен неверно(больше)",
       TestName = "Присвоение телефонного номера больше 10 символов")]
        [TestCase("769910",
       "Должно возникать исключение, если телефон введен неверно(меньше)",
       TestName = "Присвоение телефонного номера меньше 10 символов")]
        public void TestPhoneNumberSet_ArgumentException(string wrongPhoneNumber, string
       message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.PhoneNumber = wrongPhoneNumber; },
            message);
        }

        /// <summary>
        /// Позитивный тест геттера Vk
        /// </summary>
        [Test(Description = "Позитивный тест геттера Vk")]
        public void TestVkGet_CorrectValue()
        {
            // Arrange
            var expected = "allloooo";
            _contact.Vk = expected;

            // Act
            var actual = _contact.Vk;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Vk возвращает неправильный Id vk");
        }

        /// <summary>
        /// Негативный тест для проверки сеттера vk
        /// </summary>
        /// <param name="wrongVk">переменная Vk для теста</param>
        /// <param name="message">Сообщение при ошибки теста</param>
        [TestCase("", "Должно возникать исключение, если id vk-пустая строка",
      TestName = "Присвоение пустой строки в качестве Id vk номера")]
        [TestCase("90430769910904307699109043076991090430769910904307699109043076991090430769910904307699109043076991090430769910",
      "Должно возникать исключение, если id vk введен неверно",
      TestName = "Присвоение id vk больше 50 символов")]
        public void TestVkSet_ArgumentException(string wrongVk, string
      message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Vk = wrongVk; },
            message);
        }

        /// <summary>
        /// Позитивный тест геттера Email
        /// </summary>
        [Test(Description = "Позитивный тест геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            // Arrange
            var expected = "alll@oooo";
            _contact.Email = expected;

            // Act
            var actual = _contact.Email;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильный Email");
        }

        /// <summary>
        /// Негативный тест для Email
        /// </summary>
        /// <param name="wrongEmail">Переменная Email для теста</param>
        /// <param name="message">Сообщение при ошибки теста</param>
        [TestCase("", "Должно возникать исключение, если Email -пустая строка",
      TestName = "Присвоение пустой строки в качестве Email")]
        [TestCase("dklfdkldfkfk",
      "Должно возникать исключение, если Email введен без @",
      TestName = "Присвоение Email без символа @")]
        [TestCase("ллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвалллвдладвал",
      "Долж возникать исключение, если Email больше 100 символов",
      TestName = "Присвоение Email более 100 символов")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string
      message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Email = wrongEmail; },
            message);
        }

        /// <summary>
        /// Позитивный тест геттера DateOfBirth
        /// </summary>
        [Test(Description = "Позитивный тест геттера DateOfBirth")]
        public void TestDateOfBirthGet_CorrectValue()
        {
            // Arrange
            var expected = new DateTime(1999, 02, 06);
            _contact.DateOfBirth = expected;

            // Act
            var actual = _contact.DateOfBirth;

            // Assert
            Assert.AreEqual(expected, actual, "Геттер DateOfBirth возвращает неправильную дату рождения");
        }

        /// <summary>
        /// негативный тест для даты рождения
        /// </summary>
        /// <param name="wrongDate">Переменна даты рождения для теста </param>
        /// <param name="message">Сообщение при ошибки теста</param>
        [TestCase("1700,02,04",
      "Должно возникать исключение, если дата рождения меньше минимальной",
      TestName = "Присвоение DateOfBirth неправильную дату(Меньше минимальной)")]
        [TestCase("2027,02,02",
      "Долж возникать исключение, если дата рождения больше сегодняшнего дня",
      TestName = "Присвоение DateOfBirth позднее сегодняшнего дня")]
        public void TestDateOfBirthSet_ArgumentException(DateTime wrongDate, string
      message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.DateOfBirth = wrongDate; },
            message);
        }
    }
}
