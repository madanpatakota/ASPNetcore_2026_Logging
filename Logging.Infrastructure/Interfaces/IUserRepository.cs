using Logging.Domains;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logging.Infrastructure
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
    }
}
