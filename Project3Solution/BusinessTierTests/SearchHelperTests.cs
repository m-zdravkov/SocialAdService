using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessTier;
using Model;

namespace BusinessTierTests
{
    [TestClass]
    public class SearchHelperTests
    {
        [TestMethod]
        public void TestGetKeywordsFiltered()
        {
            string query = "looking for some words";
            var kw = query.GetKeywords();
            Assert.IsTrue(kw.Count == 2 && !kw.Contains("looking"));
        }

        [TestMethod]
        public void TestGetKeywordsEmpty()
        {
            string query = "";
            var kw = query.GetKeywords();

            Assert.IsTrue(kw.Count == 0);
        }
    }
}
