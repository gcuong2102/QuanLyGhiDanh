using System.ComponentModel.DataAnnotations;

namespace QuanLyGhiDanh.Models
{
    public class SignInModel
    {

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
