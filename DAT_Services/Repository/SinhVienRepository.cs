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
    public class SinhVienRepository : ISinhVienRepository
    {
        // DbContext
        private readonly DAT_DbContext _dbContext;
        public SinhVienRepository()
        {
            _dbContext = new DAT_DbContext();
        }

        public bool AddSinhVien(SinhVien sinhVien)
        {
            // Thêm sinh viên
            _dbContext.SinhViens.Add(sinhVien);
            // Lưu lại
            return _dbContext.SaveChanges() > 0;
        }

        public bool DeleteSinhVien(Guid Id)
        {
            // tìm sinh viên theo id
            // nếu tồn tại thì xóa
            // không tồn tại thì báo lỗi
            var sinhVien = _dbContext.SinhViens.FirstOrDefault(c => c.Id == Id && !c.IsDeleted);
            if (sinhVien != null)
            {
                // isDeleted = true
                sinhVien.IsDeleted = true;
                _dbContext.SinhViens.Update(sinhVien);
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }

        public List<SinhVien> GetListSinhVien()
        {
            // Lấy danh sách sinh viên
            return _dbContext.SinhViens.Where(c => !c.IsDeleted).AsNoTracking().ToList();
        }

        public SinhVien GetSinhVien(Guid Id)
        {
            // Lấy sinh viên
            return _dbContext.SinhViens.FirstOrDefault(c => c.Id == Id && !c.IsDeleted);
 
        }

        public List<SinhVien> SearchSinhVien(string stringSearch,Guid idChuyenNganh)
        {
            if (idChuyenNganh == Guid.Empty)
            {
                // Tìm kiếm sinh viên
                return _dbContext.SinhViens.Where(x => (x.MaSinhVien.Contains(stringSearch) || x.HoVaTen.Contains(stringSearch)) && !x.IsDeleted).ToList();
            }
            // Tìm kiếm sinh viên
            return _dbContext.SinhViens.Where(x => (x.MaSinhVien.Contains(stringSearch) || x.HoVaTen.Contains(stringSearch)) && !x.IsDeleted && x.ChuyenNganhId == idChuyenNganh).ToList();
        }

        public async Task<bool> UpdateSinhVien(SinhVien sinhVien)
        {
            // Kiểm tra sinh viên có tồn tại không
            // Nếu tồn tại thì cập nhật
            //sửa sinh viên
            var sinhVienUpdate = await _dbContext.SinhViens.FirstOrDefaultAsync(c => c.Id == sinhVien.Id && !c.IsDeleted);
            // nếu tồn tại thì sửa
            // nếu tồn tại thì sửa
            // không tồn tại thì báo lỗi
            if (sinhVienUpdate != null)
            {
                 _dbContext.Entry(sinhVienUpdate).CurrentValues.SetValues(sinhVien);
                return await _dbContext.SaveChangesAsync() > 0;
            }
            return false;


        }
    }
}
