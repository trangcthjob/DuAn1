using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IRepository
{
    public interface IGiangVienRepository
    {
        // them sửa xóa tìm kiếm
        // Thêm giảng viên
        public bool AddGiangVien(GiangVien giangVien);
        // Sửa giảng viên
        public bool UpdateGiangVien(GiangVien giangVien);
        // Xóa giảng viên
        public bool DeleteGiangVien(Guid Id);
        // Tìm kiếm giảng viên
        public List<GiangVien> SearchGiangVien(string maGV);
        // Lấy danh sách giảng viên
        public List<GiangVien> GetListGiangVien();
        // Lấy giảng viên
        public GiangVien GetGiangVien(Guid maGV);
    }
}
