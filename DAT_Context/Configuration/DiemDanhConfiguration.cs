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
    public class DiemDanhConfiguration:IEntityTypeConfiguration<DiemDanh>
    {
        public void Configure(EntityTypeBuilder<DiemDanh> builder)
        {
            //key
            builder.HasKey(x => x.Id);
            //property
            builder.Property(x => x.ThoiGian).IsRequired();
            builder.Property(x => x.TrangThai).IsRequired();
        }
    }
}
