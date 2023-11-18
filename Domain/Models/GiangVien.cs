using Infrastructure;
using Infrastructure.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class GiangVien:DAT_Entity
    {
        public string MaGiangVien { get; set; }
        public string TenGiangVien { get; set; }
        public DateTime? NgaySinh { get; set; }
        public GenderEnum GioiTinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        // khóa ngoại
        public ChuyenNganh? ChuyenNganh { get; set; }
        public Guid? ChuyenNganhId { get; set; }

        

    }
}
