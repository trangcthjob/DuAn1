using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IRepository
{
    public interface ISinhVienRepository
    {
        // them sửa xóa tìm kiếm
        // Thêm sinh viên
         public bool AddSinhVien(SinhVien sinhVien);
        // Sửa sinh viên
        public Task<bool> UpdateSinhVien(SinhVien sinhVien);
        // Xóa sinh viên
        public bool DeleteSinhVien(Guid Id);
        // Tìm kiếm sinh viên
        public List<SinhVien> SearchSinhVien(string maSV);
        // Lấy danh sách sinh viên
        public List<SinhVien> GetListSinhVien();
        // Lấy sinh viên
        public SinhVien GetSinhVien(Guid maSV);

    }
}
