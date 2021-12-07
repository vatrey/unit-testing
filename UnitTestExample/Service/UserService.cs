using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repository;
using Application.Models;
namespace Application.Service
{
    public class UserService
    {
        private IUserRepository Repository;
        public UserService(IUserRepository Repository)
        {
            this.Repository = Repository;
        }
        public User GetUserById(int Id)
        {
            return this.Repository.GetUserById(Id);
        }
        public virtual Boolean AddUser(User NewUser)
        {
            return this.Repository.Save(NewUser);
        }
    }
}
