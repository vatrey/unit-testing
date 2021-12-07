using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Repository
{
    public interface IUserRepository
    {
        public User GetUserById(int Id);
        public bool Save(User NewUser);   
    }
}
