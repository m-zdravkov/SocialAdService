using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessTier;
using Model;
using System.Linq;

namespace BusinessTierTests
{
    [TestClass]
    public class AdReservationTests
    {
        public static string author = "reserver0@test.com";
        public static string reservingUser = "reserver1@test.com";
        public static string thirdUser = "reserver2@test.com";
        public static string pass = "nsNUI8n4823Aag";
        public static UserControl users = UserControl.GetInstance();
        public static AdControl ads = AdControl.GetInstance();
        public static int maxReservations = 5;
        public static Ad[] toReserve = new Ad[maxReservations + 1];

        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            //Clean up possible junk in DB to set up the test
            users.DeleteUser(users.GetUserNullable(author)?.Id);
            users.DeleteUser(users.GetUserNullable(reservingUser)?.Id);
            users.DeleteUser(users.GetUserNullable(thirdUser)?.Id);

            users.RegisterUser("Reserve Unit Tester", author, "http://test.com/image.jpg", pass);
            users.RegisterUser("Reserve Unit Tester", reservingUser, "http://test.com/image.jpg", pass);
            users.RegisterUser("Reserve Unit Tester", thirdUser, "http://test.com/image.jpg", pass);
            
            //Create one more ad than needed for testing
            for (int i = 0; i < maxReservations + 1; i++)
            {
                toReserve[i] = ads.PostAd(author, "Unit Test - Reserve", "Reserve me.", "Aalborg", AdType.Selling);
            }
        }

        [TestMethod]
        public void TestReserveAd()
        {
            //Test method 5 times
            for (int i = 0; i < maxReservations; i++)
            {
                ads.ReserveAd(toReserve[i].Id, reservingUser);
            }
            
            //Get the ad's reserver (updated version of otherUser)
            var testId = toReserve[0].Id;
            User reserver = DbContextControl.GetNew().Ads.Include("ReservedBy")
                .FirstOrDefault(a => a.Id == testId).ReservedBy;

            //Ad.ReservedBy should be changed to represent a user
            Assert.IsNotNull(reserver);

            //Check that the user who reserved 5 times has no more reservations
            try
            {
                Assert.IsTrue(reserver.Reservations == 0);
            }
            catch (AssertFailedException)
            {
                throw new AssertFailedException("User should have 0 reservations left, but he has "+ reserver.Reservations+" out of "+maxReservations);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(AlreadyReservedException))]
        public void TestReserveAdReserved()
        {
            ads.ReserveAd(toReserve[0].Id, thirdUser);
        }

        [TestMethod]
        [ExpectedException(typeof(NotEnoughReservationsException))]
        public void TestReserveAdWithNoReservations()
        {
            //This ad is left unresevred, but the user has no reservations left.
            ads.ReserveAd(toReserve[maxReservations].Id, reservingUser);
        }

        [TestMethod]
        public void TestUnreserveAd()
        {
            ads.ReserveAd(toReserve[maxReservations].Id, thirdUser);
            ads.UnreserveAd(toReserve[maxReservations].Id, thirdUser);

            var testId = toReserve[0].Id;
            Ad unreservedAd = DbContextControl.GetNew().Ads.Include("ReservedBy")
                .FirstOrDefault(a => a.Id == testId);
            User reserver = UserControl.GetInstance().GetUser(thirdUser);

            //Reservations should still be 0
            Assert.IsTrue(reserver.Reservations == maxReservations - 1);

            //Ad should be unreserved
            Assert.IsNull(unreservedAd.ReservedBy);
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            for (int i = 0; i < maxReservations + 1; i++)
            {
                ads.DeleteAd(toReserve[i].Id, author);
            }

            users.DeleteUser(users.GetUserNullable(author)?.Id);
            users.DeleteUser(users.GetUserNullable(reservingUser)?.Id);
            users.DeleteUser(users.GetUserNullable(thirdUser)?.Id);
        }
    }
}
