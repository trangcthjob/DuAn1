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
    public class KiConfiguration:IEntityTypeConfiguration<KiHoc>
    {
        public void Configure(EntityTypeBuilder<KiHoc> builder)
        {
            //key
            builder.HasKey(x => x.Id);
            //property
            builder.Property(x => x.TenKiHoc).IsRequired();
            builder.Property(x => x.NgayBatDau).IsRequired();
            builder.Property(x => x.NgayBatDau).IsRequired();
        }
    }
}
