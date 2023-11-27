using Infrastructure.Enum;

namespace DAT
{
    internal class SinhVienDto
    {
        public Guid Id { get; set; }
        public string Avatar { get; set; }
        public string MaSinhVien { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public GenderEnum GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string TenChuyenNganh { get; set; }
    }
}