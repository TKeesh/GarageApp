using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using garageModel;
using garageController;
using Xunit;
using garageUtility;

namespace garageTests
{
    public class UserRepositoryTests
    {
        [Fact]
        public void AddUser()
        {
            UserRepository userRepository = UserRepository.GetInstance();
            User user = new User("tomi", "pass");
            userRepository.AddUser(user);
            Assert.Equal(true, userRepository.Contains("tomi"));
            userRepository.RemoveUser(user);
        }
        [Fact]
        public void CurrentUser()
        {
            UserRepository userRepository = UserRepository.GetInstance();
            User user = new User("tomi", "pass");
            userRepository.CurrentUser = user;
            Assert.Equal(user.Name, userRepository.CurrentUser.Name);
        }
        [Fact]
        public void RemoveUser()
        {
            UserRepository userRepository = UserRepository.GetInstance();
            User user = new User("tomi", "pass");
            userRepository.AddUser(user);
            userRepository.RemoveUser(user);
            Assert.Equal(false, userRepository.Contains("tomi"));
        }
        [Fact]
        public void GetUser()
        {
            UserRepository userRepository = UserRepository.GetInstance();
            User user = new User("tomi", "pass");
            userRepository.AddUser(user);
            User user2 = userRepository.GetUser("tomi", "pass");
            Assert.Equal(user, user2);
            userRepository.RemoveUser(user);
        }
    }
}
