using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notice_Board.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Model
{
    /// <summary>
    /// Summary description for AdministatorTest
    /// </summary>
    [TestClass]
    public class AdministatorTest
    {
        [TestMethod]
        public void ShouldReturnAdministratorObject_WhenInputIsValid()
        {
            DateTime creationDate = DateTime.ParseExact("2023-05-18 14:00:00", "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None);
            string validInput = $"Administrator:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,{creationDate:yyyy-MM-dd HH:mm:ss}";

            Administrator parsedAdmin = Administrator.Parse(validInput);

            Assert.IsNotNull(parsedAdmin);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentException_WhenInputHasInvalidDateFormat()
        {
            string invalidInput = "Administrator:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,18-05-2023 14:00:00";
            Administrator.Parse(invalidInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentException_WhenInputHasMissingFields()
        {
            string invalidInput = "Administrator:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe";
            Administrator.Parse(invalidInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentException_WhenInputDoesNotStartWithAdministrator()
        {
            string invalidInput = "User:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,2023-05-18 14:00:00";
            Administrator.Parse(invalidInput);
        }



        [TestMethod]
        public void ShouldReturnFalse_WhenInputHasMissingFields()
        {
            string invalidInput = "Administrator:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe";
            Assert.IsFalse(Administrator.TryParse(invalidInput, out _));
        }

        [TestMethod]
        public void ShouldReturnFalse_WhenInputHasInvalidDateFormat()
        {
            string invalidInput = "Administrator:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,18-05-2023 14:00:00";
            Assert.IsFalse(Administrator.TryParse(invalidInput, out _));
        }

        [TestMethod]
        public void ShouldReturnFalse_WhenInputDoesNotStartWithAdministrator()
        {
            string invalidInput = "User:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,2023-05-18 14:00:00";
            Assert.IsFalse(Administrator.TryParse(invalidInput, out _));
        }



        [TestMethod]
        public void ShouldReturnCorrectStringRepresentation()
        {
            DateTime creationDate = DateTime.ParseExact("2023-05-18 14:00:00", "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None);
            Administrator admin = new Administrator("John", "Doe", 30, "USA", "+123456789", "johndoe@gmail.com", "john_doe", "Password1", creationDate);

            string expectedOutput = $"Administrator:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,{creationDate:yyyy-MM-dd HH:mm:ss}";
            string actualOutput = admin.ToString();

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
