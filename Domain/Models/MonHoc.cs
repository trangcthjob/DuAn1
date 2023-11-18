using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class MonHoc:DAT_Entity
    {
        public string TenMonHoc { get; set; }
        public int SoTinChi { get; set; }
        // danh sách chuyên ngành
        public ICollection<ChuyenNganh> ChuyenNganhs { get; set; }

    }
}
