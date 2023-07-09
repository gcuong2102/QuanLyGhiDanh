using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Data
{
    [Table("Students")]
    public class Students
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [MaxLength(20),Required]
        public string UserId { get; set; }
        [Required,MaxLength(30)]
        public string FirstName { get; set; }
        [Required,MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        public int Sex { get; set; }
        [Required,MaxLength(30),EmailAddress]
        public string Email { get; set; }
        [MaxLength(15),Phone]
        public string Phone { get; set; }
        [Required]
        public string BirthDay { get; set; }
        [MaxLength(150)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string ParentName { get; set; }
        [MaxLength(150)]
        public string Image_Url { get; set; }
    }
}
