using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notice_Board.Model;
using System;

namespace TestProject.Model
{
    [TestClass]
    public class CountryTest
    {
        [TestMethod]
        public void CountryParse_ShouldReturnCorrectCountryObject_WhenInputIsValid()
        {
            string input = "Russia,RU,₽,7";

            Country expectedCountry = new Country("Russia", "RU", "₽", 7);
            Country actualCountry = Country.Parse(input);

            Assert.AreEqual(expectedCountry, actualCountry);
        }

        [TestMethod]
        public void CountryParse_ShouldThrowException_WhenInputIsInvalid()
        {
            string input = "Russia,7";

            Assert.ThrowsException<ArgumentException>(() => Country.Parse(input));
        }

        [TestMethod]
        public void CountryTryParse_ShouldReturnTrue_WhenInputIsValid()
        {
            string input = "Russia,RU,₽,7";

            bool result = Country.TryParse(input, out Country country);

            Assert.IsTrue(result);
            Assert.IsNotNull(country);
        }

        [TestMethod]
        public void CountryTryParse_ShouldReturnFalse_WhenInputIsInvalid()
        {
            string input = "Russia,7";

            bool result = Country.TryParse(input, out Country country);

            Assert.IsFalse(result);
            Assert.IsNull(country);
        }

        [TestMethod]
        public void CountryEquals_ShouldReturnTrue_WhenObjectsAreEqual()
        {
            Country country1 = new Country("Russia", "RU", "₽", 7);
            Country country2 = new Country("Russia", "RU", "₽", 7);

            Assert.IsTrue(country1.Equals(country2));
        }

        [TestMethod]
        public void CountryEquals_ShouldReturnFalse_WhenObjectsAreNotEqual()
        {
            Country country1 = new Country("Russia", "RU", "₽", 7);
            Country country2 = new Country("USA", "US", "$", 1);

            Assert.IsFalse(country1.Equals(country2));
        }
    }

}
