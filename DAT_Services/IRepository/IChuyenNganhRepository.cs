using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IRepository
{
    public interface IChuyenNganhRepository
    {
        // Lấy danh sách
        public List<ChuyenNganh> GetListChuyenNganh();
    }
}
