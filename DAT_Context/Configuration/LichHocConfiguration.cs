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
    public class LichHocConfiguration:IEntityTypeConfiguration<LichHoc>
    {
        public void Configure(EntityTypeBuilder<LichHoc> builder)
        { 
            //key
            builder.HasKey(x => x.Id);
            //property
            builder.Property(x => x.NgayHoc).IsRequired();
            builder.Property(x => x.LaLichThi).IsRequired();
            builder.Property(x => x.SoSV).IsRequired();
           
        }
    }
}
