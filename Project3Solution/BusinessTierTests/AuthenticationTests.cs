using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessTier;
using Model;

namespace BusinessTierTests
{
    [TestClass]
    public class AuthenticationTests
    {
        UserControl users = UserControl.GetInstance();
        User testUser;
        AuthenticationControl auth = AuthenticationControl.GetInstance();
        string testPass = "#&authT3St*(";

        [ClassInitialize]
        public void Initialize()
        {
            testUser = users.RegisterUser(
                "Unit Test","auth@unit.test","http://unit.test/image.jpg",testPass);
        }

        [TestMethod]
        public void TestLoginProper()
        {
            auth.Authenticate("auth@unit.test",testPass);
            Assert.Equals(auth.AuthenticatedUser,testUser);
        }

        [TestMethod]
        [ExpectedException(typeof(UserNotFoundException))]
        public void TestLoginNotFound()
        {
            auth.Authenticate("authNotFound@unit.test", testPass);
        }

        [TestMethod]
        [ExpectedException(typeof(WrongPasswordException))]
        public void TestLoginWrongPassword()
        {
            auth.Authenticate("auth@unit.test", "123");
        }

        [ClassCleanup]
        public void Cleanup()
        {
            users.DeleteUser(testUser.Id);
        }
    }
}
