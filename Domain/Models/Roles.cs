using Infrastructure;

namespace Domain.Models
{
    public class Roles : DAT_Entity
    {
        // Tên 
        public string? DisplayName { get; set; }
        // Mã
        public string? Code { get; set; }
        // Là mặc định
        public bool? IsDefault { get; set; }
    }
}
