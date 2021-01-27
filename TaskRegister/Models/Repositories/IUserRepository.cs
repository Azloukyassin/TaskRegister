using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskRegister.Models.Repositories
{
    public class IUserRepository : IRepository<User>
    {
        IList<User> users;
        public IUserRepository()
        {
            users = new List<User>();
        }
        public void Add(User entity)
        { 
            users.Add(entity);
        }

        public User Find(int id)
        {
            var user = users.SingleOrDefault(a => a.user_ID == id);

            return user;
        }

        public IList<User> List()
        {
            return users.ToList();
        }
    }
    }