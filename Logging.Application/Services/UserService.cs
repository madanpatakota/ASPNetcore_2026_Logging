//using Logging.Application;
using Logging.Domains;
using Logging.Infrastructure;

namespace Logging.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository _userRepo)
        {
            userRepository = _userRepo;
        }

        public List<User> GetUsersService()
        {
            // i need to communicate the repo for get the users Details.
            //priya ree, arjun & rohit

            return userRepository.GetUsers();
        }
    }
}
