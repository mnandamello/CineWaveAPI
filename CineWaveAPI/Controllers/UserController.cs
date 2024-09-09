using CineWaveAPI.Models;
using CineWaveAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CineWaveAPI.Controllers
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

        [HttpGet("{id:int}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            try
            {
                var user = await _userRepository.GetUserById(id);

                if (user == null) return NotFound();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUsers()
        {
            try
            {
                return Ok(await _userRepository.GetUsers());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddEmpregados([FromBody] User user)
        {

            try
            {
                if (user == null) return BadRequest();

                var userCreated = await _userRepository.CreateUser(user);

                return CreatedAtAction(nameof(GetUserById),
                    new { id = userCreated.Id }, userCreated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser([FromBody] User user)
        {
            try
            {
                if (user == null) return BadRequest();

                var userToUpdate = await _userRepository.GetUserById(user.Id);
                if (userToUpdate == null) return BadRequest("User não encontrado");

                var result = await _userRepository.UpdateUser(user);

                if (result == null) return BadRequest();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
