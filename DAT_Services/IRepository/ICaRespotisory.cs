using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IRepository
{
    public interface ICaRespotisory
    {
            public bool AddCaHoc(Ca ca);
            public bool RemoveCaHoc(Ca ca);
            public bool updateCaHoc(Ca ca);
            public List<Ca> GetAllCa();
    }
}
