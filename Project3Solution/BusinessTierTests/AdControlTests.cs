using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using BusinessTier;
using System.Threading;

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
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test.","Aalborg");
            Assert.IsTrue(control.GetAd(ad.Id)?.Id == ad.Id);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        [ExpectedException(typeof(PostNotFoundException))]
        public void TestDeleteAd()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test.", "Aalborg");
            control.DeleteAd(ad.Id, author);
            Assert.IsTrue(control.GetAd(ad.Id) == null);
        }

        [TestMethod]
        public void TestPostAdWithLocation()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test in Denmark.", "Denmark");
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void GetLocationObjectTest()
        {
            var location = "Denmark".GetLocationObject();
            Assert.IsTrue(location.Name == "Denmark");
        }

        [TestMethod]
        public void GetLocationParentsTest()
        {
            var parentList = "Aalborg".GetLocationObject().GetParents(true);
            Assert.IsTrue(parentList.Count == 3);
        }

        [TestMethod]
        public void GetPossibleLocationsTest()
        {
            var list = AdControl.GetInstance().GetPossibleLocationNames("Denmark");
            Assert.IsTrue(list.Count > 1);
        }

        [TestMethod]
        public void TestGetAdWithinLocation()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test in Denmark.", "Denmark");
            
            var results = control.GetAdsWithinLocation(0, 100, "Denmark");
            Assert.IsTrue(results.Count > 0);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void TestFindAd()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test in Denmark.", "Denmark");
            var results = control.FindAds(0, 100, "Denmark", "unit test");
            Assert.IsTrue(results.Count > 0);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void TestFindAdDifficult()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test in Denmark. I want Dinosours.", "Aalborg");
            var results = control.FindAds(0, 100, "Denmark", "dinosours");
            Assert.IsTrue(results.Count > 0);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void TestFindAdType()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "This ad was written by a unit test in Denmark. I want to buy Dinosours.", "Aalborg", AdType.Buying);
            var results = control.FindAds(0, 100, "Denmark", "dinosours", AdType.Buying);
            var wrongResults = control.FindAds(0, 100, "Denmark", "dinosours", AdType.Selling);
            Assert.IsTrue(results.Count > 0);
            Assert.IsTrue(wrongResults.Count == 0);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void TestFindAdNoContent()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "Should not matter what I type here.", "Aalborg", AdType.Buying);
            var results = control.FindAds(0, 100, "Denmark", "", AdType.Buying);
            Assert.IsTrue(results.Count > 0);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void TestFindAdTypeOnly()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "Should not matter what I type here.", "Aalborg", AdType.Buying);
            var results = control.FindAds(0, 100, "", "", AdType.Buying);
            Assert.IsTrue(results.Count > 0);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void TestGetAdComments()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "Should not matter what I type here.", "Aalborg", AdType.Buying);
            CommentControl.GetInstance().PostComment(ad.Id, "Test comment", "max.damage@test.com");
            var results = control.GetComments(0, 64, ad.Id);
            Assert.IsTrue(results.Count == 0);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void TestGetAdEmptyComments()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "Should not matter what I type here.", "Aalborg", AdType.Buying);
            var results = control.GetComments(0, 64, ad.Id);
            Assert.IsTrue(results.Count == 0);
            control.DeleteAd(ad.Id, author);
        }

        [TestMethod]
        public void TestGetAdMultipleComments()
        {
            var author = "max.damage@test.com";
            Ad ad = control.PostAd(author, "Unit Test", "Should not matter what I type here.", "Aalborg", AdType.Buying);
            CommentControl.GetInstance().PostComment(ad.Id, "Test comment", "max.damage@test.com");
            CommentControl.GetInstance().PostComment(ad.Id, "Test comment", "max.damage@test.com");
            CommentControl.GetInstance().PostComment(ad.Id, "Test comment", "max.damage@test.com");
            var results = control.GetComments(0, 64, ad.Id);
            control.DeleteAd(ad.Id, author);
            Assert.IsTrue(results.Count == 3);
        }
    }
}
