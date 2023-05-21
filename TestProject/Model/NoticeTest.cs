using Microsoft.VisualStudio.TestTools.UnitTesting;
using Notice_Board.Model;
using System;

namespace TestProject.Model
{
    [TestClass]
    public class NoticeTest
    {


        [TestMethod]
        public void NoticeParse_ShouldThrowException_WhenInputIsInvalid()
        {
            string input = "12345,2023-05-18,500.0,Admin,This is a notice,Test Notice,Electronics,Russia,123 Test Address,True,False";

            Assert.ThrowsException<ArgumentException>(() => Notice.Parse(input));
        }

        [TestMethod]
        public void NoticeParse_ShouldReturnCorrectNoticeObject_WhenInputIsValid()
        {
            string input = "12345,2023-05-18T10:15:30.00Z,500,Admin,This is a notice,Test Notice,Electronics,Russia,123 Test Address,True,False";

            Notice expectedNotice = new Notice("12345", DateTime.Parse("2023-05-18T10:15:30.00Z"), 500m, "Admin", "This is a notice", "Test Notice", "Electronics", "Russia", "123 Test Address", true, false);
            Notice actualNotice = Notice.Parse(input);

            Assert.AreEqual(expectedNotice, actualNotice);
        }

        [TestMethod]
        public void NoticeTitle_ShouldThrowException_WhenLengthIsInvalid()
        {
            Notice notice = new Notice(500m, "Admin", "This is a notice", "Valid Title", "Electronics", "Russia", "123 Test Address", true, false);

            Assert.ThrowsException<ArgumentException>(() => notice.Title = "");
            Assert.ThrowsException<ArgumentException>(() => notice.Title = new string('T', 33));
        }

        [TestMethod]
        public void NoticeTryParse_ShouldReturnTrue_WhenInputIsValid()
        {
            string input = "12345,2023-05-18T10:15:30.00Z,500,Admin,This is a notice,Test Notice,Electronics,Russia,123 Test Address,True,False";

            bool result = Notice.TryParse(input, out Notice notice);

            Assert.IsTrue(result);
            Assert.IsNotNull(notice);
        }

        [TestMethod]
        public void NoticeTryParse_ShouldReturnFalse_WhenInputIsInvalid()
        {
            string input = "12345,2023-05-18,500.0,Admin,This is a notice,Test Notice,Electronics,Russia,123 Test Address,True,False";

            bool result = Notice.TryParse(input, out Notice notice);

            Assert.IsFalse(result);
            Assert.IsNull(notice);
        }



        [TestMethod]
        public void NoticeDescription_ShouldThrowException_WhenLengthIsInvalid()
        {
            Notice notice = new Notice(500.0m, "Admin", "This is a notice", "Test Notice", "Electronics", "Russia", "123 Test Address", true, false);

            Assert.ThrowsException<ArgumentException>(() => notice.Description = "Short");
            Assert.ThrowsException<ArgumentException>(() => notice.Description = new string('D', 4097));
        }

        [TestMethod]
        public void NoticeTextAddress_ShouldThrowException_WhenLengthIsInvalid()
        {
            Notice notice = new Notice(500.0m, "Admin", "This is a notice", "Test Notice", "Electronics", "Russia", "123 Test Address", true, false);

            Assert.ThrowsException<ArgumentException>(() => notice.TextAddress = "123");
            Assert.ThrowsException<ArgumentException>(() => notice.TextAddress = new string('A', 257));
        }
    }
}
