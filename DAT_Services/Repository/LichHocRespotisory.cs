using DAT_Context;
using DAT_Services.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.Repository
{
    public class LichHocRespotisory 
    {
        private readonly DAT_DbContext _context;
        public LichHocRespotisory()
        {
            _context = new DAT_DbContext();
        }
        public bool AddLichHoc(LichHoc lh)
        {
            _context.Add(lh);
            _context.SaveChanges();
            return true;
        }


        public List<LichHoc> GetAllLh()
        {
           return _context.LichHocs.ToList();
        }

        public bool RemoveLichHoc(LichHoc lh)
        {
            _context.Remove(lh);
            _context.SaveChanges();
            return true;
        }

        public bool updateLichHoc(LichHoc lh)
        {
            _context.Update(lh);
            _context.SaveChanges();
            return true;
        }
    }
}
