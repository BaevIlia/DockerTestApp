using DockerTestApp.Abstractions;
using DockerTestApp.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DockerTestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllUsers() 
        {
            return Ok(await _userRepository.GetAll());
        }
    }
}
