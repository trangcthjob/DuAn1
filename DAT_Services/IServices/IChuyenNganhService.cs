using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IServices
{
    public interface IChuyenNganhService
    {
        // Lấy danh sách
        public List<ChuyenNganh> GetListChuyenNganh();
    }
}
