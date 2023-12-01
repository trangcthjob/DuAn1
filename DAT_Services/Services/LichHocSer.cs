using DAT_Services.IServices;
using DAT_Services.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Services.Services
{
    public class LichHocSer : ILichHocService
    {
        private LichHocRespotisory _repos;
        public LichHocSer()
        {
            _repos = new LichHocRespotisory();
        }
        public string Add(LichHoc lh)
        {
            if (_repos.AddLichHoc(lh) == true)
            {
                return "them thanh cong!!!!";
            }
            else
            {
                return "them that bai";
            }
        }

        public List<LichHoc> GetAllLh(string Search)
        {
            if (Search == null)
            {
                return _repos.GetAllLh();
            }
            else
            {
                return _repos.GetAllLh().Where(x => x.SoSV.Contains(Search)).ToList();
            }
        }

        public string Remove(LichHoc lh)
        {
            var clone = _repos.GetAllLh().FirstOrDefault(x => x.Id == lh.Id);
            if (_repos.RemoveLichHoc(clone) == true)
            {
                return "xoa thanh cong!!!";
            }
            else
            {
                return "xoa that bai!!!!";
            }
        }

        public string Update(LichHoc lh)
        {
            var clone = _repos.GetAllLh().FirstOrDefault(x => x.Id == lh.Id);
            clone.LopHoc = lh.LopHoc;
            clone.Ca = lh.Ca;
            clone.MonHoc = lh.MonHoc;
            clone.GiangVien = lh.GiangVien;
            clone.NgayHoc = lh.NgayHoc;
            clone.SoSV = lh.SoSV;
            if (_repos.updateLichHoc(clone) == true)
            {
                return "sua thanh cong!!!";
            }
            else
            {
                return "sua that bai";
            }
        }
    }
}
