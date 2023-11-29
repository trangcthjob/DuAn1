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
    public class GiangVienService:IGiangVienService
    {
        // Repository
        private readonly IGiangVienRepository _giangVienRepository;
        public GiangVienService()
        {
            _giangVienRepository = new GiangVienRepository();
        }
        public bool AddGiangVien(GiangVien giangVien)
        {
            // Thêm giảng viên
            return _giangVienRepository.AddGiangVien(giangVien);
        }

        public bool DeleteGiangVien(Guid Id)
        {
            // Xóa giảng viên
            return _giangVienRepository.DeleteGiangVien(Id);
        }

        public List<GiangVien> GetListGiangVien()
        {
            // Lấy danh sách giảng viên
            return _giangVienRepository.GetListGiangVien();
        }

        public GiangVien GetGiangVien(Guid maGV)
        {
            // Lấy giảng viên
            return _giangVienRepository.GetGiangVien(maGV);
        }

        public List<GiangVien> SearchGiangVien(string maGV, Guid IdCn)
        {
            // Tìm kiếm giảng viên
            return _giangVienRepository.SearchGiangVien(maGV,IdCn);
        }

        public bool UpdateGiangVien(GiangVien giangVien)
        {
            // Sửa giảng viên
            return _giangVienRepository.UpdateGiangVien(giangVien);
        }
    }
}
