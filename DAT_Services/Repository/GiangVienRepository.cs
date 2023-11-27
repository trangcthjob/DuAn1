using DAT_Context;
using DAT_Services.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.Repository
{
    public class GiangVienRepository:IGiangVienRepository
    {
        //dbcontext
        private readonly DAT_DbContext _dbContext;
        public GiangVienRepository()
        {
            _dbContext = new DAT_DbContext();
        }

        public bool AddGiangVien(GiangVien giangVien)
        {
            //thêm giảng viên
            _dbContext.GiangViens.Add(giangVien);
            //lưu lại
            return _dbContext.SaveChanges() > 0;
        }

        //sửa giảng viên
        public bool UpdateGiangVien(GiangVien giangVien)
        {
            //sửa giảng viên
            var giangVienUpdate = _dbContext.GiangViens.FirstOrDefault(c => c.Id == giangVien.Id && !c.IsDeleted);
            // nếu tồn tại thì sửa
            // không tồn tại thì báo lỗi
            if(giangVienUpdate != null)
            {
               _dbContext.Entry(giangVienUpdate).CurrentValues.SetValues(giangVien);
               return _dbContext.SaveChanges() > 0;
            }
            return false;
        }
        //Xóa giảng viên
        public bool DeleteGiangVien(Guid Id)
        {
            // tìm giảng viên theo id
            // nếu tồn tại thì xóa
            // không tồn tại thì báo lỗi
            var giangVien = _dbContext.GiangViens.FirstOrDefault(c => c.Id == Id && !c.IsDeleted);
            if (giangVien != null)
            {
                // isDeleted = true
                giangVien.IsDeleted = true;
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }
        //Tìm kiếm giảng viên
        public List<GiangVien> SearchGiangVien(string maGV)
        {
            // Tìm kiếm giảng viên
            return _dbContext.GiangViens.Where(x => x.MaGiangVien.Contains(maGV) || x.TenGiangVien.Contains(maGV) && !x.IsDeleted).ToList();
        }
        //Lấy danh sách giảng viên
        public List<GiangVien> GetListGiangVien()
        {
            // Lấy danh sách giảng viên
            return _dbContext.GiangViens.Where(c => !c.IsDeleted).AsNoTracking().ToList();
        }
        //Lấy giảng viên
        public GiangVien GetGiangVien(Guid Id)
        {
            // Lấy giảng viên
            return _dbContext.GiangViens.FirstOrDefault(c => c.Id == Id && !c.IsDeleted);
        }
    }
}
