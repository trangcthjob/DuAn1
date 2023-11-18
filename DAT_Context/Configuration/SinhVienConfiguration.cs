using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Context.Configuration
{
    public class SinhVienConfiguration:IEntityTypeConfiguration<SinhVien>
    {
        public void Configure(EntityTypeBuilder<SinhVien> builder)
        {
            //key
            builder.HasKey(x => x.Id);
            //property
            builder.Property(x => x.MaSinhVien).IsRequired();
            builder.Property(x => x.HoVaTen).IsRequired();
            builder.Property(x => x.NgaySinh).IsRequired();
            builder.Property(x => x.GioiTinh).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.SoDienThoai).IsRequired();
            builder.Property(x => x.DiaChi).IsRequired();
            

        }
    }
}
