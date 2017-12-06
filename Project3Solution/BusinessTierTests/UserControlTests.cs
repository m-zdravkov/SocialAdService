using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using BusinessTier;

namespace BusinessTierTests
{
    [TestClass]
    public class UserControlTests
    {
        static UserControl users = UserControl.GetInstance();
        
        static User testUser;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            
        }

        [TestMethod]
        public void TestAddUser()
        {
            User temporaryUser = users.RegisterUser(
            "Unit Tester", "register2@unit.test", "http://unit.test/image.jpg", "-#un1tT3st#");
            Assert.IsNotNull(temporaryUser);

            users.DeleteUser(temporaryUser.Id);
        }

        [TestMethod]
        public void TestGetUser()
        {
            testUser = users.RegisterUser(
                "Unit Tester", "register1@unit.test", "http://unit.test/image.jpg", "-#un1tT3st#");

            User userFound = users.GetUser(testUser.Email);
            Assert.IsTrue(userFound.Id.Equals(testUser.Id));

            users.DeleteUser(testUser.Id);
        }

        [TestMethod]
        [ExpectedException(typeof(UserNotFoundException))]
        public void TestGetNonExistentUser()
        {
            User userTest = users.GetUser("A honest politician");
        }

        [TestMethod]
        public void TestDeleteUser()
        {
            User deleteUser = users.RegisterUser(
            "Unit Tester", "delete@unit.test", "http://unit.test/image.jpg", "-#un1tT3st#");
            
            users.DeleteUser(deleteUser.Id);
            //Assert that no exception occured
            Assert.IsTrue(true);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            //users.DeleteUser(testUser.Id);
        }
    }
}
