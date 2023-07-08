using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyGhiDanh.Data
{
    [Table("Roles")]
    public class Roles
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
