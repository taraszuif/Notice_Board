using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notice_Board.Model;
using Notice_Board.Repository;
using System;
using System.Collections.Generic;
using System.IO.Abstractions.TestingHelpers;

namespace TestProject.Repository
{
    [TestClass]
    public class CountryRepositoryTest
    {
        private CountryRepository repository;

        [TestInitialize]
        public void TestInitialize()
        {
            var fileSystem = new MockFileSystem();
            repository = CountryRepository.GetInstance("countries.json");
            repository.Clear();
        }

        [TestMethod]
        public void Create_AddsCountryToRepository()
        {
            // Arrange
            var country = new Country("Country 1", "C1", "$", 1);

            // Act
            repository.Create(country);

            // Assert
            CollectionAssert.Contains(repository.GetAll(), country);
        }

        [TestMethod]
        public void Update_ModifiesExistingCountry()
        {
            // Arrange
            var country1 = new Country("Country 1", "C1", "$", 1);
            repository.Create(country1);
            var updatedCountry = new Country("Country 1", "C1", "€", 2);

            // Act
            repository.Update(updatedCountry);
            var result = repository.Read("Country 1");

            // Assert
            Assert.AreEqual(updatedCountry, result);
        }

        [TestMethod]
        public void Delete_RemovesCountryFromRepository()
        {
            // Arrange
            var country1 = new Country("Country 1", "C1", "$", 1);
            repository.Create(country1);

            // Act
            repository.Delete("Country 1");

            // Assert
            CollectionAssert.DoesNotContain(repository.GetAll(), country1);
        }





        [TestMethod]
        public void Clear_RemovesAllCountriesFromRepository()
        {
            // Arrange
            var countries = new List<Country>
            {
                new Country("Country 1", "C1", "$", 1),
                new Country("Country 2", "C2", "€", 2)
            };
            foreach (var country in countries)
            {
                repository.Create(country);
            }

            // Act
            repository.Clear();

            // Assert
            Assert.IsTrue(repository.GetAll().Count == 0);
        }
    }
}
