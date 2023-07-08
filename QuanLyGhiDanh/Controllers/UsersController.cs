using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyGhiDanh.Models;
using QuanLyGhiDanh.Repositories;

namespace QuanLyGhiDanh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public UsersController(IUserRepository repo) 
        {
            _userRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            try
            {
                return Ok(await _userRepo.GetAllUsersAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByID(string id)
        {
            try
            {
                var book = await _userRepo.GetUserAsync(id);
                return book == null ? NotFound() : Ok(book);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(UserModel model)
        {
            try
            {
                var newUserId = await _userRepo.AddUserAsync(model);
                var user = await _userRepo.GetUserAsync(newUserId);
                return user == null? NotFound() : Ok(user);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, UserModel model)
        {
            await _userRepo.UpdateUserAsync(id,model);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string id)
        {
            await _userRepo.DeleteUserAsync(id);
            return Ok();
        }
    }
}
