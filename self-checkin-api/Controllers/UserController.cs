using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using self_checkin_api.Contracts;
using self_checkin_api.Models;
using System.Threading.Tasks;

namespace self_checkin_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            try
            {
                User user = await _userRepository.GetUser(id);
                return Ok(user);
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
