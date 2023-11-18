using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DiemDanh:DAT_Entity
    {
        public LichHoc? LichHoc { get; set; }
        public Guid? LichHocId { get; set; }
        public Guid? SinhVienId { get; set; }
        public DateTime? ThoiGian { get; set; }
        // 1: có mặt, 0: vắng mặt
        public bool? TrangThai { get; set; }
       
    }
}
