using DAT_Context;
using Domain.Models;
using DAT_Services.IRepository;
using DAT_Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.Repository
{
    internal class CaRespotisory : ICaRespotisory
    {
        private DAT_DbContext _context;
        public CaRespotisory()
        {
            _context = new DAT_DbContext();
        }
        public bool AddCaHoc(Ca ca)
        {
            _context.Add(ca);
            _context.SaveChanges();
            return true;
        }

        public List<Ca> GetAllCa()
        {
            return _context.Cas.ToList();
            

        }

        public bool RemoveCaHoc(Ca ca)
        {
            _context.Remove(ca);
            _context.SaveChanges();
            return true; 
        }

        public bool updateCaHoc(Ca ca)
        {
            _context.Update(ca);
            _context.SaveChanges();
            return true;
        }
    }
}
