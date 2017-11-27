﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using BusinessTier;

namespace BusinessTierTests
{
    /// <summary>
    /// Summary description for AdTests
    /// </summary>
    [TestClass]
    public class AdControlTests
    {
        static AdControl control = AdControl.GetInstance();
        public AdControlTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestPostAd()
        {
            User author = new User { Email = "max.damage@test.com" };
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test.");
            control.DeleteAd(ad.Id);
        }

        [TestMethod]
        public void TestPostAdWithLocation()
        {
            User author = new User { Email = "max.damage@test.com" };
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test in Denmark.", "Denmark");
            control.DeleteAd(ad.Id);
        }

        [TestMethod]
        public void TestFindAd()
        {
            User author = new User { Email = "max.damage@test.com" };
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test in Denmark.", "Denmark");
            control.FindAds(0, 100, "Denmark", "unit test");
            control.DeleteAd(ad.Id);
        }
    }
}
