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
    public class MonHocConfiguration:IEntityTypeConfiguration<MonHoc>
    {
        public void Configure(EntityTypeBuilder<MonHoc> builder)
        {
            //key
            builder.HasKey(x => x.Id);
            //property
            builder.Property(x => x.TenMonHoc).IsRequired().IsUnicode();
            builder.Property(x => x.SoTinChi).IsRequired();
        }
    }
}
