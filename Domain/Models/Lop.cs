using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Lop:DAT_Entity
    {
        public ChuyenNganh? ChuyenNganh { get; set; }
        public Guid? ChuyenNganhId { get; set; }
        public string TenLop { get; set; }
        // kì học
        public ICollection<KiHoc> KiHocs { get; set; }
        
    }
}
