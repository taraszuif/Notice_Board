using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notice_Board.Model;
using System;

namespace TestProject.Model
{
    [TestClass]
    public class CategoryTest
    {
        [TestMethod]
        public void CategoryParse_ShouldReturnCorrectCategoryObject_WhenInputIsValid()
        {
            string input = "Electronics.Phones.Smartphones";
            string expectedOutput = input;

            Category actualCategory = Category.Parse(input);

            Assert.AreEqual(expectedOutput, actualCategory.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CategoryParse_ShouldThrowException_WhenInputIsEmpty()
        {
            string input = "";
            Category actualCategory = Category.Parse(input);
        }

        [TestMethod]
        public void CategoryTryParse_ShouldReturnFalse_WhenInputIsEmpty()
        {
            string input = "";
            bool result = Category.TryParse(input, out Category actualCategory);
            Assert.IsFalse(result);
            Assert.IsNull(actualCategory);
        }

        [TestMethod]
        public void CategoryTryParse_ShouldReturnTrue_WhenInputIsValid()
        {
            string input = "Electronics.Phones.Smartphones";
            bool result = Category.TryParse(input, out Category actualCategory);
            Assert.IsTrue(result);
            Assert.IsNotNull(actualCategory);
        }

        [TestMethod]
        public void CategoryToString_ShouldReturnCorrectStringRepresentation_WhenCategoryHasSubcategory()
        {
            string expectedOutput = "Electronics.Phones.Smartphones";
            Category category = new Category("Electronics")
            {
                Subcategory = new Category("Phones")
                {
                    Subcategory = new Category("Smartphones")
                }
            };

            string actualOutput = category.ToString();

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void CategoryToString_ShouldReturnCorrectStringRepresentation_WhenCategoryHasNoSubcategory()
        {
            string expectedOutput = "Electronics";
            Category category = new Category("Electronics");

            string actualOutput = category.ToString();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
