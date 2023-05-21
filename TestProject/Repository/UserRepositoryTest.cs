using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notice_Board.Model;
using Notice_Board.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Abstractions.TestingHelpers;
using System.Linq;
using System.Text.Json;

namespace TestProject.Repository
{
    [TestClass]
    public class UserRepositoryTest
    {
        private const string TestUserFileName = "testUsers.json";
        private const string TestAdminFileName = "testAdmins.json";

        private void CreateMockFiles()
        {
            var users = new List<User>
            {
                new User("TestUser1", "TestLastName1", 20, "TestCountry1", "TestPhone1", "test1@test.com", "testLogin1", "testPassword1"),
                new User("TestUser2", "TestLastName2", 30, "TestCountry2", "TestPhone2", "test2@test.com", "testLogin2", "testPassword2"),
            };
            var admins = new List<Administrator>
            {
                new Administrator("TestAdmin1", "TestLastName1", 40, "TestCountry1", "TestPhone1", "admin1@test.com", "testLogin1", "testPassword1"),
                new Administrator("TestAdmin2", "TestLastName2", 50, "TestCountry2", "TestPhone2", "admin2@test.com", "testLogin2", "testPassword2"),
            };
            File.WriteAllText(TestUserFileName, JsonSerializer.Serialize(users));
            File.WriteAllText(TestAdminFileName, JsonSerializer.Serialize(admins));
        }


        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(TestUserFileName))
            {
                File.Delete(TestUserFileName);
            }

            if (File.Exists(TestAdminFileName))
            {
                File.Delete(TestAdminFileName);
            }
        }


        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestRead_NonExistingUser_KeyNotFoundException()
        {
            CreateMockFiles();

            var userRepository = UserRepository.GetInstance(TestUserFileName, TestAdminFileName);
            userRepository.Read("nonExistingLogin");
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestUpdate_ExistingUser_Success()
        {

            CreateMockFiles();

            var userRepository = UserRepository.GetInstance(TestUserFileName, TestAdminFileName);
            var existingUser = userRepository.Read("testLogin1");
            existingUser.FirstName = "UpdatedName";
            userRepository.Update(existingUser);

            var updatedUser = userRepository.Read("testLogin1");

            Assert.IsNotNull(updatedUser);
            Assert.AreEqual("UpdatedName", updatedUser.FirstName);
        }


        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestDelete_ExistingUser_Success()
        {
            Cleanup();

            CreateMockFiles();

            var userRepository = UserRepository.GetInstance(TestUserFileName, TestAdminFileName);
            userRepository.Delete("testLogin1");

            userRepository.Read("testLogin1");
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void TestDelete_NonExistingUser_KeyNotFoundException()
        {
            Cleanup();

            CreateMockFiles();

            var userRepository = UserRepository.GetInstance(TestUserFileName, TestAdminFileName);
            userRepository.Delete("nonExistingLogin");
        }


        [TestMethod]
        public void TestCreate_ValidUser_UserAdded()
        {
            // Arrange
            CreateMockFiles();
            var userRepository = UserRepository.GetInstance(TestUserFileName, TestAdminFileName);
            var newUser = new User("TestUser3", "TestLastName3", 25, "TestCountry3", "TestPhone3", "test3@test.com", "testLogin3", "testPassword3");

            // Act
            userRepository.Create(newUser);

            // Assert
            var createdUser = userRepository.Read(newUser.Login);
            Assert.AreEqual(newUser.Login, createdUser.Login);
        }

    }
}
