using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using BusinessTier;

namespace BusinessTierTests
{
    [TestClass]
    public class UserControlTests
    {
        static User user1 = new User
        {
            Id = "UserUnitTestID00000001",
            Name = "Tester",
            Email = "email@service.com",
            PictureURL = "http://test.com/image.jpg",
            Boosts = 0,
            Reservations = 0,
            PasswordHash = new byte[256]
        };

        static UserControl users = UserControl.GetInstance();

        [TestMethod]
        public void TestAdd()
        {
            users.AddUser(user1);
            //Assert no exception occured
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestGet()
        {
            User query = new User
            {
                Name = user1.Name,
                Email = user1.Email
            };

            User userTest = users.GetUser(query);

            Assert.IsTrue(userTest.Id.Equals( user1.Id ));
        }

        [TestMethod]
        public void TestDelete()
        {
            User testUser = new User
            {
                Id = "UserUnitTestID00000002",
                Name = "Tester",
                Email = "email@service.com",
                PictureURL = "http://test.com/image.jpg",
                Boosts = 0,
                Reservations = 0,
            };
            
            users.AddUser(testUser);
            users.DeleteUser(testUser.Id);
        }

        [TestMethod]
        public void TestRegister()
        {
            User registeredUser = users.RegisterUser(
                "Tester",
                "register@unit.test",
                "http://test.com/image.jpg",
                "Don't hack my p4ssw0rd, please! 1234");

            Assert.IsNotNull(registeredUser);

            users.DeleteUser(registeredUser.Id);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            users.DeleteUser(user1.Id);
        }
    }
}
