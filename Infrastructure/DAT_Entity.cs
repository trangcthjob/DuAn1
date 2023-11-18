using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    /// <summary>
    /// Lớp ảo có sẵn các thuộc tính chung
    /// </summary>
    public class DAT_Entity : IDAT_Entity
    {
        public Guid Id { get; set; }
        // IsDeleted
        public bool IsDeleted { get; set; }
    }
}
