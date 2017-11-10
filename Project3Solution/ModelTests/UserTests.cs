using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace ModelTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestInvalid()
        {
            User invalidUser1 = new User
            {
                Name = "joe",
                PictureURL = "123",
                PasswordHash = new byte[256],
                Salt = new byte[256],
                Email = "1@2",
                Reservations = -1,
                Boosts = -1,
                DateRegistered = DateTime.Now
            };

            Assert.IsFalse(invalidUser1.Validate()); 
        }

        [TestMethod]
        public void TestValid()
        {
            User validUser1 = new User
            {
                Name = "john doe",
                Email = "john.doe@email.com",
                PictureURL = "http://images.com/myimage.jpg",
                PasswordHash = new byte[256],
                Salt = new byte[256],
                Reservations = 0,
                Boosts = 0,
                DateRegistered = DateTime.Now
            };

            Assert.IsTrue(validUser1.Validate());
        }
    }
}
