using Logging.API.DTOs;
using Logging.Application;
using Microsoft.AspNetCore.Mvc;

namespace Logging.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService service) {
            _userService = service;
        }


        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var UsersData = _userService.GetUsersService();

            //List<UserDTO> usersDTO = new List<UserDTO>();

            //foreach (var user in UsersData)
            //{
            //    var userDto = new UserDTO()
            //    {
            //        Id        = user.Id,
            //        FirstName = user.FirstName,
            //        LastName  = user.LastName
            //    };
            //    usersDTO.Add(userDto);
            //}

            return Ok(UsersData);

        }

    }
}
