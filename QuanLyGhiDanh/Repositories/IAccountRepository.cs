using Microsoft.AspNetCore.Identity;
using QuanLyGhiDanh.Models;

namespace QuanLyGhiDanh.Repositories
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel model);
        public Task<string> SignInAsync(SignInModel model);
    }
}
