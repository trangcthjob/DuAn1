using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.IServices
{
    internal interface ICaService
    {
        public string Add(Ca ca);
        public string Remove(Ca ca);
        public string Update(Ca ca);
        public List<Ca> GetAllca(string Search);
    }
}
