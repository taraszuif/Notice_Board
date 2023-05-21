using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Notice_Board.Model;
using Notice_Board.Repository;
using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Linq;
using System.Text.Json;

namespace TestProject.Repository
{
    [TestClass]
    public class NoticeRepositoryTest
    {
        private NoticeRepository repository;
        private Mock<IFileSystem> fileSystemMock;

        [TestInitialize]
        public void TestInitialize()
        {
            fileSystemMock = new Mock<IFileSystem>();

            repository = NoticeRepository.GetInstance();
            repository.Clear();

            repository.OnSave += SaveHandler;
            repository.OnLoad += LoadHandler;
        }
        private void SaveHandler()
        {
        }

        private void LoadHandler()
        {
        }

        [TestMethod]
        public void Create_AddsNoticeToRepository()
        {
            // Arrange
            var notice = new Notice(10, "John", "Test Noticeппппппппппппппппп", "Test", "Category", "Country", "Address", true, true);

            // Act
            repository.Create(notice);

            // Assert
            Assert.IsTrue(repository.GetAll().Contains(notice));
        }

        [TestMethod]
        public void Read_ReturnsCorrectNotice()
        {
            // Arrange
            var notice = new Notice(10, "John", "Test Noticeпппппппппппппппппп", "Test", "Category", "Country", "Address", true, true);
            repository.Create(notice);

            // Act
            var result = repository.Read(notice.Id);

            // Assert
            Assert.AreEqual(notice, result);
        }

        [TestMethod]
        public void Update_ModifiesExistingNotice()
        {
            repository.Clear();
            // Arrange
            var notice = new Notice(10, "John", "Test Noticeппппппппппппппппппппп", "Test", "Category", "Country", "Address", true, true);
            repository.Create(notice);
            var updatedNotice = new Notice(20, "John", "Updated Noticeппппппппппп", "Updated Test", "Category", "Country", "Address", true, true);
            updatedNotice.Id = notice.Id;

            // Act
            repository.Update(updatedNotice);
            var result = repository.Read(notice.Id);

            // Assert
            Assert.AreEqual(updatedNotice, result);
        }

        [TestMethod]
        public void Delete_RemovesNoticeFromRepository()
        {
            // Arrange
            var notice = new Notice(10, "John", "Test Noticeпппппппппппппппппппп", "Test", "Category", "Country", "Address", true, true);
            repository.Create(notice);

            // Act
            repository.Delete(notice.Id);

            // Assert
            Assert.IsFalse(repository.GetAll().Contains(notice));
        }


        [TestMethod]
        public void GetNoticeCountByUser_ReturnsCorrectCount()
        {
            // Arrange
            var user1Notices = new List<Notice>
            {
                new Notice(10, "John", "Test Notice 1пппппппппппппппппппппппппп", "Test 1", "Category", "Country", "Address", true, true),
                new Notice(20, "John", "Test Notice 2пппппппппппппппппппппп", "Test 2", "Category", "Country", "Address", true, true)
            };
            var user2Notices = new List<Notice>
            {
                new Notice(30, "Alice", "Test Notice 3пппппппппппппппп", "Test 3", "Category", "Country", "Address", true, true)
            };
            foreach (var notice in user1Notices.Concat(user2Notices))
            {
                repository.Create(notice);
            }

            // Act
            var count1 = repository.GetNoticeCountByUser("John");
            var count2 = repository.GetNoticeCountByUser("Alice");
            var count3 = repository.GetNoticeCountByUser("Bob"); // User does not exist

            // Assert
            Assert.AreEqual(2, count1);
            Assert.AreEqual(1, count2);
            Assert.AreEqual(0, count3);
        }

        [TestMethod]
        public void SortByPriceAscending_ReturnsNoticesSortedByPriceAscending()
        {
            repository.Clear();
            // Arrange
            var notices = new List<Notice>
            {
                new Notice(30, "John", "Notice 1пппппппппппппппппп", "Test 1", "Category", "Country", "Address", true, true),
                new Notice(20, "John", "Notice 2ппппппппппппппп", "Test 2", "Category", "Country", "Address", true, true),
                new Notice(40, "John", "Notice 3ппппппппппппп", "Test 3", "Category", "Country", "Address", true, true),
            };

            // Act
            var sortedNotices = repository.SortByPriceAscending(notices);

            // Assert
            var expectedOrder = new List<decimal> { 20, 30, 40 };
            CollectionAssert.AreEqual(expectedOrder, sortedNotices.Select(n => n.Price).ToList());
        }

        [TestMethod]
        public void SortByPriceDescending_ReturnsNoticesSortedByPriceDescending()
        {
            // Arrange
            var notices = new List<Notice>
            {
                new Notice(30, "John", "Notice 1пппппппппппппппппп", "Test 1", "Category", "Country", "Address", true, true),
                new Notice(20, "John", "Notice пппппппппппппппппппппп2", "Test 2", "Category", "Country", "Address", true, true),
                new Notice(40, "John", "Notice 3ппппппппппппппппппп", "Test 3", "Category", "Country", "Address", true, true),
            };

            // Act
            var sortedNotices = repository.SortByPriceDescending(notices);

            // Assert
            var expectedOrder = new List<decimal> { 40, 30, 20 };
            CollectionAssert.AreEqual(expectedOrder, sortedNotices.Select(n => n.Price).ToList());
        }

        [TestMethod]
        public void FilterByCategory_ReturnsNoticesFilteredByCategory()
        {
            repository.Clear();
            // Arrange

            repository.Create(new Notice(10, "John", "Notice 1пппппппппппппппппп", "Test 1", "Category 1", "Country", "Address", true, true));
            repository.Create(new Notice(20, "John", "Notice 2пппппппппппппппппп", "Test 2", "Category 2", "Country", "Address", true, true));
            repository.Create(new Notice(30, "John", "Notice 3пппппппппппппппппп", "Test 3", "Category 1", "Country", "Address", true, true));


            // Act
            var filteredNotices = repository.FilterByCategory("Category 1");

            // Assert
            Assert.AreEqual(2, filteredNotices.Count);
            CollectionAssert.AllItemsAreInstancesOfType(filteredNotices, typeof(Notice));
        }
    }
}
