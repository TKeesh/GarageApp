using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using garageModel;
using garageController;
using Xunit;
using garageUtility;

namespace garageTests
{
    public class UserTests
    {
        [Fact]
        public void ConstructFull()
        {
            User user = new User("tomi", "pass");
            Assert.Equal("tomi", user.Name);
            Assert.Equal("pass", user.PasswordUnHashed);
            Assert.Equal(User.HashPassword("pass"), user.PasswordHashed);
        }
        [Fact]
        public void Construct()
        {
            User user = new User("tomi");
            Assert.Equal("tomi", user.Name);
            Assert.Equal(null, user.PasswordUnHashed);
            Assert.Equal(null, user.PasswordHashed);
        }
    }
}
