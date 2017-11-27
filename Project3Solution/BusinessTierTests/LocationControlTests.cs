using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using BusinessTier;

namespace BusinessTierTests
{
    [TestClass]
    public class LocationControlTests
    {
        [TestMethod]
        public void TestAddDeleteLocation()
        {
            var control = LocationControl.GetInstance();
            control.RegisterLocation("Unit Test City",LocationType.City);
            control.DeleteLocation("Unit Test City");
        }

        [TestMethod]
        public void TestNestedLocations()
        {
            var control = LocationControl.GetInstance();
            control.RegisterLocation("Unit Test Country", LocationType.Country);
            control.RegisterLocation("Unit Test City 1", LocationType.City, "Unit Test Country");
            control.RegisterLocation("Unit Test City 2", LocationType.City, "Unit Test Country");

            control.DeleteLocation("Unit Test City 1");
            control.DeleteLocation("Unit Test City 2");
            control.DeleteLocation("Unit Test Country");
        }

        [TestMethod]
        public void TestLoationIsWithin()
        {
            var control = LocationControl.GetInstance();

            Assert.IsTrue(control.IsWithin("Aalborg","Denmark"));
            Assert.IsTrue(control.IsWithin("Aalborg", "Aalborg"));
        }

        [TestMethod]
        public void TestLoationIsNotWithin()
        {
            var control = LocationControl.GetInstance();

            Assert.IsFalse(control.IsWithin("Germany", "Poland"));
        }
    }
}
