//using Logging.Application;
using Logging.Domains;
using Logging.Infrastructure;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace Logging.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        private readonly ILogger<UserService> _logger;

        public UserService(IUserRepository _userRepo, ILogger<UserService> logger)
        {
            userRepository = _userRepo;
            _logger = logger;
        }

        public List<User> GetUsersService()
        {
            // i need to communicate the repo for get the users Details.
            //priya ree, arjun & rohit

            try
            {
                _logger.LogInformation("Hit to the servcie for get the records");

                var data = userRepository.GetUsers();


                //json string
                string str = JsonSerializer.Serialize(data);
                _logger.LogInformation("YOu got the data and data is : {str}" , str);

                 

                return userRepository.GetUsers();

            }
            catch (Exception ex)
            {
                _logger.LogError("Something is wrong about the servcies");
                return null;
            }


        }
    }
}
