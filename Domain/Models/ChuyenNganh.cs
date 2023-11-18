using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ChuyenNganh:DAT_Entity
    {
        // ChuyenNganh
        public ChuyenNganh? ChuyenNganhCha { get; set; }
        // khóa ngoại
        public Guid? ChuyenNganhChaId { get; set; }
        public string MaChuyenNganh { get; set; }
        public string TenChuyenNganh { get; set; }
        // danh sách sinh viên
        public ICollection<SinhVien>? SinhViens { get; set; }
        // danh sách môn học
        public ICollection<MonHoc>? MonHocs { get; set; }

    }
}
