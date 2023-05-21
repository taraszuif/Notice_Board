using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Notice_Board.Model;
using Notice_Board.Repository;
using System;
using System.Collections.Generic;
using System.IO.Abstractions;
using System.Text.Json;

namespace TestProject.Repository
{
    [TestClass]
    public class CategoryRepositoryTest
    {
        private CategoryRepository repository;
        private Mock<IFileSystem> fileSystemMock;

        [TestInitialize]
        public void TestInitialize()
        {
            fileSystemMock = new Mock<IFileSystem>();


            repository = CategoryRepository.GetInstance("categories.json");
            repository.Clear();
        }


        [TestMethod]
        public void Create_AddsCategoryToRepository()
        {
            // Arrange
            var category = new Category("Category 1");

            // Act
            repository.Create(category);

            // Assert
            Assert.IsTrue(repository.GetAll().Count != 0);
        }

        [TestMethod]
        public void Read_ReturnsCorrectCategory()
        {
            // Arrange
            var category = new Category("Category 1");
            repository.Create(category);

            // Act
            var result = repository.Read(category.Id);

            // Assert
            Assert.AreEqual(category, result);
        }

        [TestMethod]
        public void Update_ModifiesExistingCategory()
        {
            // Arrange
            var category = new Category("Category 1");
            repository.Create(category);
            var updatedCategory = new Category("Category 2");
            updatedCategory.Id = category.Id;

            // Act
            repository.Update(updatedCategory);
            var result = repository.Read(category.Id);

            // Assert
            Assert.AreEqual(updatedCategory, result);
        }

        [TestMethod]
        public void Delete_RemovesCategoryFromRepository()
        {
            // Arrange
            var category = new Category("Category 1");
            repository.Create(category);

            // Act
            repository.Delete(category.Id);

            // Assert
            Assert.IsFalse(repository.GetAll().Contains(category));
        }


        [TestMethod]
        public void Clear_RemovesAllCategoriesFromRepository()
        {
            // Arrange
            var categories = new List<Category>
            {
                new Category("Category 1"),
                new Category("Category 2")
            };
            foreach (var category in categories)
            {
                repository.Create(category);
            }

            // Act
            repository.Clear();

            // Assert
            Assert.IsTrue(repository.GetAll().Count == 0);
        }
    }
}
