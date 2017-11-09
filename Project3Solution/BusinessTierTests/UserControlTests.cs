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
            PictureURL = "http://asoijdaosifjaf/image.jpg",
            Boosts = 0,
            Reservations = 0,
            Password = "aoigjoiatjseot349yujsiojgofi"
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
                PictureURL = "http://asoijdaosifjaf/image.jpg",
                Boosts = 0,
                Reservations = 0,
                Password = "aoigjoiatjseot349yujsiojgofi"
            };
            
            users.AddUser(testUser);
            users.DeleteUser(testUser.Id);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            users.DeleteUser(user1.Id);
        }
    }
}
