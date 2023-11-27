using DAT_Context;
using DAT_Services.IRepository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.Repository
{
    public class ChuyenNganhRepository : IChuyenNganhRepository
    {
        // Db context
        private readonly DAT_DbContext _context;
        public ChuyenNganhRepository()
        {
            _context = new DAT_DbContext();
        }
        public List<ChuyenNganh> GetListChuyenNganh()
        {
            // Lấy danh sách chuyên ngành
            return _context.ChuyenNganhs.ToList();
        }
    }
}
