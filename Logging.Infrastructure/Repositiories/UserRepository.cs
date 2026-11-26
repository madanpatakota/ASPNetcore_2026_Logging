using Logging.Domains;
using Logging.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logging.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetUsers()
        {
            return new List<User>()
            {
                new User
                {
                    Id = 1,
                    FirstName = "Rahul",
                    LastName = "Sharma",
                    Age = 29,
                    Email = "rahul.sharma@example.com"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Priya",
                    LastName = "Reddy",
                    Age = 26,
                    Email = "priya.reddy@example.com"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Arjun",
                    LastName = "Kumar",
                    Age = 32,
                    Email = "arjun.kumar@example.com"
                }
            };
        }
    }
}
