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

        [TestMethod]
        public void TestAdd()
        {
            testUser = users.RegisterUser(
            "Unit Tester", "register1@unit.test", "http://unit.test/image.jpg", "-#un1tT3st#");
            Assert.IsNotNull(testUser);
        }

        [TestMethod]
        public void TestGet()
        {
            User query = new User
            {
                Name = testUser.Name,
                Email = testUser.Email
            };

            User userTest = users.GetUser(query);

            Assert.IsTrue(userTest.Id.Equals(testUser.Id ));
        }

        [TestMethod]
        public void TestDelete()
        {
            /*User deleteUser = users.RegisterUser(
            "Unit Tester", "delete@unit.test", "http://unit.test/image.jpg", "-#un1tT3st#");

            users.AddUser(deleteUser);*/
            users.DeleteUser(testUser.Id);
            //Assert that no exception occured
            Assert.IsTrue(true);
        }

        /*[ClassCleanup]
        public static void Cleanup()
        {
            users.DeleteUser(testUser.Id);
        }*/
    }
}
