using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UserDto
    {
        [Required]
        public string TenKH { get; set; }

        [Required]
        public string DiaChi { get; set; }

        [Required]
        public string DienThoai { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
