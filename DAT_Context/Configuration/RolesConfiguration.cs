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
    public class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
           // key
           builder.HasKey(x => x.Id);
            // property
            builder.Property(x => x.DisplayName).IsRequired();
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.IsDefault).IsRequired();
        }
    }
}
