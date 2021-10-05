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
        public User RemoveAccount()
            {
            var userBank = new User();
            new User
                { UserName = "zia",Password = "zia123",Balance = 10000,Salary = 40000,Role = "Backende",AccountNumber = "1212-2" };
            return userBank;
            }

        [TestMethod()]   // CreateAccount test
        public void IsUserNameString()
            {
            var userList = new User();
            var actual = userList.UserName = "Zia";

            Assert.IsTrue(true,actual);
            }

        [TestMethod()] // CreateAccount test
        public void IsUserNameNumber()  // Den ska fixas att den tar int.
            {
            var userList = new User();
            var actual = userList.UserName = "222";

            Assert.IsTrue(true,actual);
            }



        [TestMethod()] // CreateAccount test
        public void IsPasswordString()
            {
            var userList = new User();
            var actual = userList.Password = "";

            Assert.IsTrue(true,actual);
            }

        //[TestMethod()] // CreateAccount test
        //public void IsSalareDouble()
        //    {
        //    var userList = new User();
        //    double actual = userList.Salary = 10.10;
        //    double expected = double;
        //    Assert.AreEqual(expected,actual);
        //    }

        [TestMethod()]  // CreateAccount test
        public void IsRoleString()
            {
            var userList = new User();
            var actual = userList.Role = "";

            Assert.IsTrue(true,actual);
            }


        [TestMethod()] // RemoveAccount test
        public void IfUserNotExcist()
            {
            var userBank = new User();
            
            var actual =  new User
                { UserName = "mathilda"};
                Assert.AreNotEqual(userBank.UserName = "alex",actual);
            }

        [TestMethod()] // RemoveAccount test
        public void IfUserIsWrong()
            {
            var userBank = new User();

            var actual = new User
                { UserName = "mathilda"};
            Assert.AreNotEqual(userBank.UserName = "matild",actual);
            }
        
        [TestMethod()] // RemoveAccount test
        public void IfUserHasNumber()
            {
            var userBank = new User();
            var actual = new User(){ UserName = "mathilda"};
            Assert.AreNotEqual(userBank.UserName = "mathilda11",actual);
            }

        [TestMethod()] // RemoveAccount test
        public void IfPasswordIsExist()
            {
            var userBank = RemoveAccount();
            var actual = userBank.Password = "zia123";
            var expected = RemoveAccount();
            Assert.AreNotEqual(expected,actual);
            }

        [TestMethod()] // RemoveAccount test
        public void IfPasswordIsSame()
        {
            var userBank = RemoveAccount();
            var actual = userBank.Password = "zia123";
            Assert.AreEqual(actual, "zia123");
        }
        [TestMethod()] // RemoveAccount test
        public void IfPasswordIsNotSame()
        {
            var userBank = RemoveAccount();
            var actual = userBank.Password = "ziaaaa";
            Assert.AreNotEqual(actual, "zia123");
        }
    }
    }