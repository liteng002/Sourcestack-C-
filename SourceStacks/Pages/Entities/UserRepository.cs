﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStacks.Entities
{
    public class UserRepository
    {
        private static IList<User> users;
        static UserRepository()
        {
            users = new List<User>
            {
                new User
                {
                    Id = 1,
                },
            };
        }

        internal IList<User> Get(int pageIndex, int pageSize)
        {
            return users.Skip((pageIndex - 1) * pageSize)
                .Take(pageSize).ToList();
        }
        public UserRepository()
        {
        }

        internal User Find(int id)
        {
            return users.Where(a => id == id).SingleOrDefault();
        }

        internal User GetByName(string name)
        {
            return users.Where(u => u.Name == name).SingleOrDefault();
        }

        void Delete()
        {

        }

        public void Save(User user)
        {
            users.Add(user);
        }
    }
}
