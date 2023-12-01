using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IRepository
{
    public interface ICaRepository
    {
        public bool AddCa(Ca caHoc);
        public bool UpdateCa(Ca CaHoc);
        public bool DeleteCa(String nameCaHoc);
        public List<Ca> SearchCa(string stringSearch, String nameCaHoc);
        public List<Ca> GetListCa();
    }
}
