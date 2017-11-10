using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessTier;
using Model;

namespace BusinessTierTests
{
    [TestClass]
    public class AuthenticationTests
    {
        UserControl users = UserControl.GetInstance();
        User testUser;

        [ClassInitialize]
        public void Initialize()
        {
            testUser = users.RegisterUser(
                "Unit Test","auth@unit.test","http://unit.test/image.jpg","#&authT3St*(");
        }

        [TestMethod]
        public void TestLogin()
        {
            
        }

        [ClassCleanup]
        public void Cleanup()
        {
            users.DeleteUser(testUser.Id);
        }
    }
}
