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
    public class ProjectTests
    {
        [Test(Description = "Позитивный тест по передачи правильного списка")]
        public void TestProject_CorrectValue()
        {
            // Arrange
            var testProject = InitProject();

            // Act
            var expectedList = testProject.Contacts;

            // Assert
            Assert.AreEqual(expectedList, testProject.Contacts,
            "Был передан неправильный список");
        }

        [Test(Description = "Позитивный тест сортировки c отсартирвоанными контактами")]
        public void TestSortContactsByFullName()
        {
            // Arrange
            var testProject = InitProjectSort();

            // Act
            IEnumerable<string> expected = new[]
            {
                "FullName1", "FullName2", "FullName3",
            };
            List<Contact> sortedContacts = testProject.SortContactsByFullName();

            // Assert
            Assert.IsTrue(sortedContacts.Select(n => n.FullName).SequenceEqual(expected),
            "Список отсортирован неверно");
        }


        [Test(Description = "Позитивный тест сортировки c несортированными контактами")]
        public void TestSortContactsByFullName_1()
        {
            // Arrange
            var testProject = InitProject();

            // Act
            IEnumerable<string> expected = new[]
            {
                "FullName1", "FullName2", "FullName3",
            };
            List<Contact> sortedContacts = testProject.SortContactsByFullName();

            // Assert
            Assert.IsTrue(sortedContacts.Select(n => n.FullName).SequenceEqual(expected),
            "Список отсортирован неверно");
        }

        /// <summary>
        /// Позитивный поиск с заданной подстрокой и сущестующим списком
        /// </summary>
        /// <param name="substring"></param>
        [TestCase("FullName1", TestName = "Тест сортировки с верной  подстрокой")]
        public void TestFindContactsByFullName_CorrectValue(string substring)
        {
            // Arrange
            var testProject = InitProject();

            // Act
            IEnumerable<string> expected = new[]
            {
                "FullName1",
            };
            List<Contact> sortedContacts = testProject.FindByFullName(substring);

            // Assert
            Assert.IsTrue(sortedContacts.Select(n => n.FullName).SequenceEqual(expected),
                     "Список отсортирован неверно");
        }

        [TestCase("FullName1", TestName = "Тест сортировки с задананной подстракой и пустым списком")]
        public void TestFindContactsByFullName_EmptyList(string substring)
        {
            // Arrange
            var testProject = new Project();

            // Act
            List<Contact> sortedContacts = testProject.FindByFullName(substring);

            // Assert
            Assert.IsEmpty(sortedContacts,
                     "Список отсортирован неверно");
        }

        [TestCase("", TestName = "Тест сортировки с пустой подстрокой")]
        public void TestFindContactsByFullName_EmptySubstring(string wrongSubstring)
        {
            // Arrange
            var testProject = InitProjectSort();

            // Act
            IEnumerable<string> expected = new[]
            {
                "FullName1", "FullName2", "FullName3",
            };
            List<Contact> sortedContacts = testProject.FindByFullName(wrongSubstring);

            // Assert
            Assert.IsTrue(sortedContacts.Select(n => n.FullName).SequenceEqual(expected),
            "Список отсортирован неверно");
        }

        [Test(Description = "Негативный тест сортировки")]
        public void TestSortContactsByFullName_EmptyList()
        {
            // Arrange
            var testProject = new Project();

            // Act
            List<Contact> sortedContacts = testProject.SortContactsByFullName();

            // Assert
            Assert.IsEmpty(sortedContacts, "Список осторирован по строке неверно");
        }


        /// <summary>
        /// Негативный тест
        /// </summary>
        /// <param name="wrongSubstring"></param>
        [TestCase("1testsFullName111", TestName = "Тест сортировки с подстрокой больше фамилии")]
        public void TestFindContactsByFullName_WrongSubstring(string wrongSubstring)
        {
            // Arrange
            var testProject = InitProject();

            // Act
            List<Contact> sortedContacts = testProject.FindByFullName(wrongSubstring);

            // Assert
            Assert.IsEmpty(sortedContacts, "Список осторирован по строке неверно");
        }

        static public Project InitProject()
        {
            var testProject = new Project();

            testProject.Contacts.Add(new Contact(
            "FullName2",
            "Test@Email1",
            "9043769910",
            "TestiDVK1",
            new DateTime(2000, 1, 1)
            ));

            testProject.Contacts.Add(new Contact(
            "FullName1",
            "Test@Email2",
            "9043769911",
            "TestiDVK",
            new DateTime(2005, 05, 01)));

            testProject.Contacts.Add(new Contact(
            "FullName3",
            "Test@Email3",
            "9043799913",
            "TestiDVK3",
            new DateTime(2002, 03, 11)));

            return testProject;
        }

        static public Project InitProjectSort()
        {
            var testProject = new Project();

            testProject.Contacts.Add(new Contact(
            "FullName1",
            "Test@Email1",
            "9043769910",
            "TestiDVK1",
            new DateTime(2000, 1, 1)
            ));

            testProject.Contacts.Add(new Contact(
            "FullName2",
            "Test@Email2",
            "9043769911",
            "TestiDVK",
            new DateTime(2005, 05, 01)));

            testProject.Contacts.Add(new Contact(
            "FullName3",
            "Test@Email3",
            "9043799913",
            "TestiDVK3",
            new DateTime(2002, 03, 11)));

            return testProject;
        }
    }
}
