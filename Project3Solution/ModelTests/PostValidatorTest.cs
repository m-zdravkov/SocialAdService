using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace ModelTests
{
    [TestClass]
    public class PostValidatorTest
    {
        [TestMethod]
        //Test minimum character limit
        public void TestContent1()
        {
            Comment postObject = new Comment
            {
                Content = "1234",
                ImageSource = "NaN"
                
            };

            Assert.IsFalse(postObject.ValidatePost());

        }


        [TestMethod]   
        //Test maximum character limit
        public void TestContent2()
        {
            Comment postObject = new Comment
            {
                Content = "Lorem ipsum dolor sit amet, consetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque pen",
                ImageSource = "NaN"
                
            };

            Assert.IsFalse(postObject.ValidatePost());
        }
        [TestMethod]
        //Test URL link
        //NOTE: Changed: Assert.IsFalse TO Assert.IsTrue
        public void TestImageSource1()
        {
            Comment postObject = new Comment
            {
                Content = "NaNi",
                ImageSource = "http://images.com/myimage.jpg"
            };

            Assert.IsTrue(postObject.ValidatePost());
        }
    }
}
