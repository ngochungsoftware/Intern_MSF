namespace WebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string TenKH { get; set; } = string.Empty;

        public string DiaChi { get; set; } = string.Empty;

        public string DienThoai { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
