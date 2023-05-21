using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notice_Board.Model;
using System;

namespace TestProject.Model
{
    [TestClass]
    public class UserTest
    {
        private User user;

        [TestInitialize]
        public void Setup()
        {
            user = new User("John", "Doe", 30, "USA", "+123456789", "johndoe@gmail.com", "john_doe", "Password1");
        }

        [TestMethod]
        public void User_CreateUser_ShouldCreateUserSuccessfully()
        {
            Assert.AreEqual("John", user.FirstName);
            Assert.AreEqual("Doe", user.LastName);
            Assert.AreEqual(30, user.Age);
            Assert.AreEqual("USA", user.Country);
            Assert.AreEqual("+123456789", user.Phone);
            Assert.AreEqual("johndoe@gmail.com", user.Email);
            Assert.AreEqual("john_doe", user.Login);
            Assert.AreEqual("Password1", user.Password);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_SetLogin_ShouldThrowArgumentException_WhenInvalidLength()
        {
            user.Login = "jd";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_SetPassword_ShouldThrowArgumentException_WhenInvalidFormat()
        {
            user.Password = "passwordwithoutdigit";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_SetFirstName_ShouldThrowArgumentException_WhenInvalidLength()
        {
            user.FirstName = "J";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_SetLastName_ShouldThrowArgumentException_WhenInvalidLength()
        {
            user.LastName = "D";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_SetAge_ShouldThrowArgumentException_WhenInvalidAge()
        {
            user.Age = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_SetEmail_ShouldThrowArgumentException_WhenInvalidEmail()
        {
            user.Email = "invalidEmail";
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_Parse_ShouldThrowArgumentException_WhenInputIsInvalid()
        {
            string invalidInput = "Invalid input string";
            User.Parse(invalidInput);
        }

        [TestMethod]
        public void User_TryParse_ShouldReturnFalse_WhenInputIsInvalid()
        {
            string invalidInput = "Invalid input string";
            Assert.IsFalse(User.TryParse(invalidInput, out _));
        }
        [TestMethod]
        public void User_Parse_ShouldReturnUserObject_WhenInputIsValid()
        {
            DateTime creationDate = DateTime.ParseExact("2023-05-18 14:00:00", "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None);
            string validInput = $"User:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,{creationDate:yyyy-MM-dd HH:mm:ss}";

            User parsedUser = User.Parse(validInput);

            User expectedUser = new User("John", "Doe", 30, "USA", "+123456789", "johndoe@gmail.com", "john_doe", "Password1", creationDate);

            Assert.AreEqual(expectedUser.ToString(), parsedUser.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_Parse_ShouldThrowArgumentException_WhenInputHasInvalidDateFormat()
        {
            string invalidInput = "User:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,18-05-2023 14:00:00";
            User.Parse(invalidInput);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void User_Parse_ShouldThrowArgumentException_WhenInputHasMissingFields()
        {
            string invalidInput = "User:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe";
            User.Parse(invalidInput);
        }

        [TestMethod]
        public void User_TryParse_ShouldReturnFalse_WhenInputHasMissingFields()
        {
            string invalidInput = "User:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe";
            Assert.IsFalse(User.TryParse(invalidInput, out _));
        }

        [TestMethod]
        public void User_TryParse_ShouldReturnFalse_WhenInputHasInvalidDateFormat()
        {
            string invalidInput = "User:John,Doe,30,USA,+123456789,johndoe@gmail.com,john_doe,Password1,18-05-2023 14:00:00";
            Assert.IsFalse(User.TryParse(invalidInput, out _));
        }
    }
}