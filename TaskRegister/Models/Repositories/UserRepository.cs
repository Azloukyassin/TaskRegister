using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskRegister.Models.Repositories
{
    public class UserRepository : IRepository<User>
    {
        IList<User> users;
        public UserRepository()
        {
            users = new List<User>();
        }
        public void Add(User entity , int id)
        {
            entity.user_ID = id + 1;
            users.Add(entity);
        }

        public User Find(int id)
        {
            var user = users.Where(a => a.user_ID == id).First();
            return user;
        }

        public IList<User> List()
        {
            return users.ToList();
        }
    }
    }