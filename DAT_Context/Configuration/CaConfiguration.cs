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
    public class CaConfiguration:IEntityTypeConfiguration<Ca>
    {
        public void Configure(EntityTypeBuilder<Ca> builder)
        {
            //key
            builder.HasKey(x => x.Id);
            //property
            builder.Property(x => x.TenCa).IsRequired();
            builder.Property(x => x.ThoiGianBatDau).IsRequired();
            builder.Property(x => x.ThoiGianKetThuc).IsRequired();
        }
    }
}
