using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IServices
{
    public interface ILichHocService
    {
        public string Add(LichHoc lh);
        public string Remove(LichHoc lh);
        public string Update(LichHoc lh);
        public List<LichHoc> GetAllLh(string Search);
    }
}
