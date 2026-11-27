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
        private readonly ILogger<UserController> _logger;


        public UserController(IUserService service , ILogger<UserController> logger)
        {
            _userService = service;
            _logger = logger;
        }


        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {

            //User hit the GetAllUsers
            _logger.LogInformation("User hit the GetAllUsers");

            _logger.LogInformation("HTTP Method: {Method}", HttpContext.Request.Method);

            _logger.LogInformation("Scheme: {Scheme}", HttpContext.Request.Scheme);

            _logger.LogInformation("Protocol: {Protocol}", HttpContext.Request.Protocol);

            _logger.LogInformation("Host: {Host}", HttpContext.Request.Host);

            _logger.LogInformation("Path: {Path}", HttpContext.Request.Path);

            _logger.LogInformation("Client IP: {IP}", HttpContext.Connection.RemoteIpAddress);

            _logger.LogInformation("User Agent: {UserAgent}", HttpContext.Request.Headers.UserAgent.ToString());

            //_logger.LogInformation("User Name: {UserName}", HttpContext.User.Identity?.Name);

            //_logger.LogInformation("Trace ID: {TraceId}", HttpContext.TraceIdentifier);


            var UsersData = _userService.GetUsersService();

            _logger.LogInformation("You have succesully get the information");



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
