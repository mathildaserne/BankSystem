using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankSystem.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Model;

namespace BankSystem.Controller.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()] // createAccountTest
        public void IfUserNameHasLetterAndDigit()
        {
            var user = new User();
            var actual = user.UserName = "zia16";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsTrue(expected, actual);
        }
        [TestMethod()] // createAccountTest
        public void IfUserNameDoesNotHaveDigit()
        {
            var user = new User();
            var actual = user.UserName = "zia";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsFalse(expected, actual);
        }
        [TestMethod()] // createAccountTest
        public void IfUserNameDoesNotHaveLetter()
        {
            var user = new User();
            var actual = user.UserName = "222";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsFalse(expected, actual);
        }
        [TestMethod()] // createAccountTest
        public void IfUserNameDoesIsEmpty()
        {
            var user = new User();
            var actual = user.UserName = "   ";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsFalse(expected, actual);
        }
        [TestMethod()] // createAccountTest
        public void IfUserNameHasSymbol()
        {
            var user = new User();
            var actual = user.UserName = "@@@@@@";
            var expected = user.UserName.Any(Char.IsLetter) && user.UserName.Any(Char.IsDigit);
            Assert.IsFalse(expected, actual);
        }
        public void IfPasswordHasLetterAndDigit()
        {
            var user = new User();
            var actual = user.Password = "zia16";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsTrue(expected, actual);
        }
        [TestMethod()] // createAccountTest
        public void IfPasswordDoesNotHaveDigit()
        {
            var user = new User();
            var actual = user.Password = "zia";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsFalse(expected, actual);
        }
        [TestMethod()] // createAccountTest
        public void IfPasswordDoesNotHaveLetter()
        {
            var user = new User();
            var actual = user.Password = "222";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsFalse(expected, actual);
        }
        [TestMethod()] // createAccountTest
        public void IfPasswordDoesIsEmpty()
        {
            var user = new User();
            var actual = user.Password = "   ";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsFalse(expected, actual);
        }
        [TestMethod()] // createAccountTest
        public void IfPasswordHasSymbol()
        {
            var user = new User();
            var actual = user.Password = "@@@@@@";
            var expected = user.Password.Any(Char.IsLetter) && user.Password.Any(Char.IsDigit);
            Assert.IsFalse(expected, actual);
        }
    }
}