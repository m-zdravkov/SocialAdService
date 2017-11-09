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
                Password = "123",
                Email = "1@2",
                Reservations = -1,
                Boosts = -1,
                DateRegistered = DateTime.Now
            };

            

            UserValidator validator1 = new UserValidator(invalidUser1);
            

            Assert.IsFalse(validator1.ValidateUser());
            
        }

        [TestMethod]
        public void TestValid()
        {
            User validUser1 = new User
            {
                Name = "john doe",
                Email = "john.doe@email.com",
                PictureURL = "http://images.com/myimage.jpg",
                Password = "124i53290uas9884ufas89f04uq9hge98u",
                Reservations = 0,
                Boosts = 0,
                DateRegistered = DateTime.Now
            };

            UserValidator validator1 = new UserValidator(validUser1);

            Assert.IsTrue(validator1.ValidateUser());
        }
    }
}
