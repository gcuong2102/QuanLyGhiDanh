using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyGhiDanh.Models;
using QuanLyGhiDanh.Repositories;

namespace QuanLyGhiDanh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _repo;

        public StudentsController(IStudentRepository repo) 
        { 
            _repo = repo;
        }
        [HttpPost("AddStudent")]
        public async Task<IActionResult> AddStudent(StudentDTO model)
        {
            var result = await _repo.AddStudentAsync(model);
            if (string.IsNullOrEmpty(result))
            {
                return BadRequest();
            }
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            var students = await _repo.GetAllStudentAsync();
            return Ok(students);
        }

    }
}
