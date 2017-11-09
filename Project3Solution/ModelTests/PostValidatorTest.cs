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
            Post postObject = new Post
            {
                Content = "1234",
                ImageSource = "NaN"
                
            };

            PostValidator validator1 = new PostValidator(postObject);

            Assert.IsFalse(validator1.ValidatePost());

        }


        [TestMethod]   
        //Test maximum character limit
        public void TestContent2()
        {
            Post postObject = new Post
            {
                Content = "Lorem ipsum dolor sit amet, consetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque pen",
                ImageSource = "NaN"
                
            };

            PostValidator validator1 = new PostValidator(postObject);

            Assert.IsFalse(validator1.ValidatePost());
        }
        [TestMethod]
        //Test URL link
        //NOTE: Changed: Assert.IsFalse TO Assert.IsTrue
        public void TestImageSource1()
        {
            Post postObject = new Post
            {
                Content = "NaNi",
                ImageSource = "http://images.com/myimage.jpg"
            };

            PostValidator validator1 = new PostValidator(postObject);

            Assert.IsTrue(validator1.ValidatePost());
        }
    }
}
