using QuanLyGhiDanh.Models;

namespace QuanLyGhiDanh.Repositories
{
    public interface IStudentRepository
    {
        public Task<string> AddStudentAsync(StudentDTO student);
        public Task UpdateStudentAsync(string studentId,StudentDTO student);
        public Task DeleteStudentAsync(string studentId);
        public Task<StudentDTO> GetStudentByIdAsync(string studentId);
        public Task<StudentDTO> GetStudentByNameAsync(string studentName);
        public Task<List<StudentDTO>> GetAllStudentAsync();
    }
}
