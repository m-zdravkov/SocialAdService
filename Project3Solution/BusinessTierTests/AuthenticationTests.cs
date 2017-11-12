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
        static UserControl users = UserControl.GetInstance();
        static User testUser, testUser2;
        static AuthenticationControl auth = AuthenticationControl.GetInstance();
        static string testPass = "#&authT3St*(";

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            testUser = users.RegisterUser(
                "Unit Test","auth@unit.test","http://unit.test/image.jpg",testPass);
            testUser2 = users.RegisterUser(
                "Unit Test", "auth2@unit.test", "http://unit.test/image.jpg", testPass);
        }

        [TestMethod]
        public void TestLoginProper()
        {
            auth.Authenticate(testUser.Email,testPass);
            Assert.AreEqual(auth.AuthenticatedUser.Id, testUser.Id);
        }

        [TestMethod]
        public void TestPasswordMatching()
        {
            User user = new User();
            user.GeneratePassword("password");

            Assert.IsTrue(user.MatchPassword("password",user.Salt,user.PasswordHash));
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

        public void TestLoginSwitch()
        {
            if (auth.AuthenticatedUser == null)
                auth.Authenticate(testUser.Email, testPass);

            auth.Authenticate(testUser2.Email, testPass);
            Assert.AreEqual(auth.AuthenticatedUser.Id, testUser2.Id);
        }

        [TestMethod]
        public void TestLogout()
        {
            if(auth.AuthenticatedUser == null)
                auth.Authenticate(testUser.Email, testPass);

            auth.LogOut();
            Assert.IsTrue(auth.AuthenticatedUser == null);
        }

        [TestMethod]
        [ExpectedException(typeof(UserNotFoundException))]
        public void TestLogoutTwice()
        {
            if (auth.AuthenticatedUser != null)
                auth.LogOut();

            auth.LogOut();
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            users.DeleteUser(testUser.Id);
            users.DeleteUser(testUser2.Id);
        }
    }
}
