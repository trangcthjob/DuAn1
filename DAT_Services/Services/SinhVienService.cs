using DAT_Services.IRepository;
using DAT_Services.IServices;
using DAT_Services.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.Services
{
    public class SinhVienService : ISinhVienService
    {
        // Repository
        private readonly ISinhVienRepository _sinhVienRepository;
        public SinhVienService()
        {
            _sinhVienRepository = new SinhVienRepository();
        }
        public bool AddSinhVien(SinhVien sinhVien)
        {
            // Thêm sinh viên
            return _sinhVienRepository.AddSinhVien(sinhVien);
        }

        public bool DeleteSinhVien(Guid Id)
        {
            // Xóa sinh viên
            return _sinhVienRepository.DeleteSinhVien(Id);
        }

        public List<SinhVien> GetListSinhVien()
        {
            // Lấy danh sách sinh viên
            return _sinhVienRepository.GetListSinhVien();
        }

        public SinhVien GetSinhVien(Guid maSV)
        {
            // Lấy sinh viên
            return _sinhVienRepository.GetSinhVien(maSV);
        }

        public List<SinhVien> SearchSinhVien(string maSV)
        {
            // Tìm kiếm sinh viên
            return _sinhVienRepository.SearchSinhVien(maSV);
        }

        public async Task<bool> UpdateSinhVien(SinhVien sinhVien)
        {
            // Sửa sinh viên
            return await _sinhVienRepository.UpdateSinhVien(sinhVien);
        }
    }
}
