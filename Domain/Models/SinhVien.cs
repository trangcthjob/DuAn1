using Infrastructure;
using Infrastructure.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SinhVien:DAT_Entity
    {
        public string MaSinhVien { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public GenderEnum GioiTinh { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public ChuyenNganh? ChuyenNganh { get; set; }
        public Guid? ChuyenNganhId { get; set; }      

    }
}
