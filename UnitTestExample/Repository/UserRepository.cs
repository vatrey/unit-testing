using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> Db;
        public UserRepository()
        {
            this.Db = new List<User>
            {
                new User{Name = "John Doe", Id=1, Email="jhondoe@gmail.com", DateOfJoining=DateTime.Parse("12/6/2021"), Salary=123456},
                new User{Name = "baker John", Id=1, Email="baker12@gmail.com", DateOfJoining=DateTime.Parse("12/6/2020"), Salary=12345},
                new User{Name = "Hugh Baker", Id=1, Email="baker@gmail.com", DateOfJoining=DateTime.Parse("12/6/2019"), Salary=1234}
            };
        }
        public User GetUserById(int Id)
        {
            return Db.Find(u => u.Id == Id);
        }
        public bool Save(User NewUser)
        {
            foreach (User ele in Db) 
            {
                if (ele.Id == NewUser.Id) return false;
            }
            Db.Add(NewUser);
            return true;
        }
    }
}
