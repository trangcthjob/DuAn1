using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Context.Seeding
{
    public static class RolesSeeding
    {
        public static void SeedData(DAT_DbContext _DbContext)
        {
            // kiểm tra xem bảng Roles có dữ liệu chưa
            if (_DbContext.Roles.Any())
            {
                return;
            }
            var lstRoles = new List<Domain.Models.Roles>()
            {
                new Domain.Models.Roles()
                {
                    Id = Guid.NewGuid(),
                    DisplayName = "Admin",
                    Code = "Admin",
                    IsDefault = true
                },
            };
            _DbContext.Roles.AddRange(lstRoles);
            _DbContext.SaveChanges();
        }
    }
}
