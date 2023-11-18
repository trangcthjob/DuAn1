using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class KiHoc:DAT_Entity
    {
       
        public string TenKiHoc { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        // lớp
        public ICollection<Lop> Lops { get; set; }
    }
}
