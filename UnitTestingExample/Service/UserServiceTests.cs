using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Application.Repository;
using Application.Service;
using Application.Models;

namespace UnitTests.Service
{
    [TestFixture]
    public class UserServiceTests
    {
        private UserService userService;
        //private Mock<IUserRepository> _mockUserRepository;
        [SetUp]
        public void SetUp()
        {
            this.userService = new UserService(new UserRepository());
            //this._mockUserRepository = new Mock<IUserRepository>();
            //this.UserService = new UserService(_mockUserRepository.Object);
        }
        [Test]
        public void TestToAddNewUser()
        {
            User user = new() { Name = "Castle Wain", Email = "waincastle@gmail.com", Id = 3, DateOfJoining = DateTime.Parse("12/07/2021"), Salary = 123214 };
            //_mockUserRepository.Setup(x => x.Save(user)).Returns(true);
            bool ans = userService.AddUser(user);
            Assert.IsTrue(ans);
        }
    }
}
