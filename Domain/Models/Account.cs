using Infrastructure;
using Infrastructure.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Account : DAT_Entity
    {
        /// <summary>
        /// Tên hiển thị
        /// </summary>
        public string? DisplayName{ get; set; }
        /// <summary>
        /// Tên tài khoản
        /// </summary>
        public string? UserName { get; set; }
        /// <summary>
        /// Mật khẩu
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string? Phone { get; set; }
        
        public GenderEnum Gender { get; set; }
        public Roles? Roles { get; set; }
        public Guid? RolesId { get; set; }
        // Avatar của tài khoản
        public string? Avatar { get; set; }

    }
}
