using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuanLyGhiDanh.Data;
using QuanLyGhiDanh.Models;

namespace QuanLyGhiDanh.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EnrollmentContext _context;
        private readonly IMapper _mapper;

        public UserRepository(EnrollmentContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<string> AddUserAsync(UserModel user)
        {
            var newUser = _mapper.Map<Users>(user);
            _context.Users!.Add(newUser);
            await _context.SaveChangesAsync();
            return newUser.Id;
        }

        public async Task DeleteUserAsync(string id)
        {
            var deleteUser = _context.Users.Where(x => x.Id == id).SingleOrDefault();
            if(deleteUser != null)
            {
                _context.Users!.Remove(deleteUser);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            var users = await _context.Users.ToListAsync();
            return _mapper.Map<List<UserModel>>(users);
        }

        public async Task<UserModel> GetUserAsync(string id)
        {
            var user = await _context.Users!.FindAsync(id);
            return _mapper.Map<UserModel>(user);
        }

        public async Task UpdateUserAsync(string id, UserModel model)
        {
            if(id== model.Id)
            {
                var updateBook = _mapper.Map<Users>(model);
                _context.Users.Update(updateBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
