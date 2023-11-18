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
    public class ChuyenNganhConfiguration:IEntityTypeConfiguration<ChuyenNganh>
    {
        public void Configure(EntityTypeBuilder<ChuyenNganh> builder)
        {
            //key
            builder.HasKey(x => x.Id);
            //property
            builder.Property(x => x.TenChuyenNganh).IsRequired().IsUnicode();
            builder.Property(x => x.MaChuyenNganh).IsRequired();

           
        }
    }
}
