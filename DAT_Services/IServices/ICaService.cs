using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IServices
{
    public interface ICaService
    {
        public bool AddCa(Ca caHoc);
        public bool UpdateCa(Ca caHoc);
        public bool DeleteCa(string nameCaHoc);
        public List<Ca> SearchCa(string stringSearch, String nameCaHoc);
        public List<Ca> GetListCa();

    }
}
