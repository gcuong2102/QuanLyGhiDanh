using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace QuanLyGhiDanh.Data
{
    public class EnrollmentContext : IdentityDbContext<ApplicationUser>
    {
        public EnrollmentContext(DbContextOptions<EnrollmentContext> options) : base(options)
        {

        }
        #region DbSet
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Actions> Actions { get; set; }
        public DbSet<Students> Students { get; set; }
        #endregion
    }
}
 