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
    public class CaRepository : ICaRepository
    {
        private readonly DAT_DbContext _dbContext;
        public CaRepository()
        {
            _dbContext = new DAT_DbContext();
        }

        public bool AddCa(Ca caHoc)
        {
            _dbContext.Cas.Add(caHoc);
            return _dbContext.SaveChanges() > 0;
        }

        public bool UpdateCa(Ca caHoc)
        {
            var caHocUpdate = _dbContext.Cas.FirstOrDefault(c => c.TenCa == caHoc.TenCa && !c.IsDeleted);
            // nếu tồn tại thì sửa
            // không tồn tại thì báo lỗi
            if (caHocUpdate != null)
            {
                _dbContext.Entry(caHocUpdate).CurrentValues.SetValues(caHoc);
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }
        public bool DeleteCa(string nameCaHoc)
        {
            var caHoc = _dbContext.Cas.FirstOrDefault(c => c.TenCa == nameCaHoc && !c.IsDeleted);
            if (caHoc != null)
            {
                // isDeleted = true
                caHoc.IsDeleted = true;
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }
        public List<Ca> SearchCa(string stringSearch, String nameCaHoc)
        {
            return _dbContext.Cas.Where(x => (x.TenCa.Contains(stringSearch)) && !x.IsDeleted && x.TenCa == nameCaHoc).ToList();
        }
        public List<Ca> GetListCa()
        {
            return _dbContext.Cas.Where(c => !c.IsDeleted).AsNoTracking().ToList();
        }
        public Ca GetCa(string nameCahoc)
        {
            return _dbContext.Cas.FirstOrDefault(c => c.TenCa == nameCahoc && !c.IsDeleted);
        }
    }
}
