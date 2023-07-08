using QuanLyGhiDanh.Data;
using QuanLyGhiDanh.Models;

namespace QuanLyGhiDanh.Repositories
{
    public interface IUserRepository
    {
        public Task<List<UserModel>> GetAllUsersAsync();
        public Task<UserModel> GetUserAsync(string id);
        public Task<string> AddUserAsync(UserModel user);
        public Task UpdateUserAsync(string id,UserModel user);
        public Task DeleteUserAsync(string id);
    }
}
