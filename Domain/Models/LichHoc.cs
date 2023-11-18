using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class LichHoc:DAT_Entity
    {
        public Lop? LopHoc { get; set; }
        public Guid LopHocId{ get; set; }
        public Ca? Ca { get; set; }
        public Guid CaID { get; set; }
        // Môn học
        public MonHoc? MonHoc { get; set; }
        public Guid MonHocId { get; set; }
        // Giảng viên
        public GiangVien? GiangVien { get; set; }
        public Guid? GiangVienId { get; set; }
        // danh sách điểm danh
        public ICollection<DiemDanh>? DiemDanhs { get; set; }
        public DateTime NgayHoc { get; set; }
        public bool LaLichThi { get; set; }
        public string SoSV { get; set; }
    }
}
