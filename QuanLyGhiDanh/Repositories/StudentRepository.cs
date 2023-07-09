using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuanLyGhiDanh.Data;
using QuanLyGhiDanh.Models;

namespace QuanLyGhiDanh.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly EnrollmentContext _db;
        private readonly IMapper _mapper;
        public StudentRepository(EnrollmentContext db, IMapper mapper)
        {
            _mapper = mapper; 
            _db = db;
        }
        public async Task<string> AddStudentAsync(StudentDTO student)
        {
            var newStudent = _mapper.Map<Students>(student);
            if (student == null)
            {
                return "";
            }
            _db.Students.Add(newStudent);
            await _db.SaveChangesAsync();
            return newStudent.Id;
        }

        public async Task DeleteStudentAsync(string studentId)
        {
            if(!string.IsNullOrEmpty(studentId) && _db.Students.Where(x=>x.Id == studentId).Count()!=0) 
            {
                var student = await _db.Students.FindAsync(studentId);
                _db.Students.Remove(student);
            }
            await _db.SaveChangesAsync();
        }

        public async Task<List<StudentDTO>> GetAllStudentAsync()
        {
            var students = await _db.Students.ToListAsync();
            return _mapper.Map<List<StudentDTO>>(students);
        }

        public async Task<StudentDTO> GetStudentByIdAsync(string studentId)
        {
            var student = await _db.Students.FindAsync(studentId);
            return _mapper.Map<StudentDTO>(student);
        }

        public async Task<StudentDTO> GetStudentByNameAsync(string studentName)
        {
            var student = await _db.Students.Where(x=>x.LastName == studentName).SingleOrDefaultAsync();
            return _mapper.Map<StudentDTO>(student);
        }

        public async Task UpdateStudentAsync(string studentId, StudentDTO student)
        {
            if (string.IsNullOrEmpty(studentId) || student == null) return;
            var updateStudent = _mapper.Map<Students>(student);
            _db.Students.Update(updateStudent);
            await _db.SaveChangesAsync();
        }
    }
}
