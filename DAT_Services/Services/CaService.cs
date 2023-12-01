using DAT_Services.IServices;
using Domain.Models;
using DAT_Services.IRepository;
using DAT_Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_Context;

namespace DAT_Services.Services
{
    public class CaService : ICaService
    {
        private CaRespotisory _repos;
        public CaService()
        {
            _repos = new CaRespotisory();
        }
        public string Add(Ca ca)
        {
            if (_repos.AddCaHoc(ca) == true)
            {
                return "them thanh cong!!!!";
            }
            else
            {
                return "them that bai";
            }
        }

        public List<Ca> GetAllca(string Search)
        {
            if (Search == null)
            {
                return _repos.GetAllCa();
            }
            else
            {
                return _repos.GetAllCa().Where(x => x.TenCa.Contains(Search)).ToList();
            }
        }

        public string Remove(Ca ca)
        {
            var clone = _repos.GetAllCa().FirstOrDefault(x => x.Id == ca.Id);
            if (_repos.RemoveCaHoc(clone) == true)
            {
                return " xóa thành công!!!";
            }
            else
            {
                return "xóa thất bại!!!!";
            }
        }

        public string Update(Ca ca)
        {
            var clone = _repos.GetAllCa().FirstOrDefault(x => x.Id == ca.Id);
            clone.TenCa = ca.TenCa;
            clone.ThoiGianBatDau = ca.ThoiGianBatDau;
            clone.ThoiGianKetThuc = ca.ThoiGianKetThuc;
            if (_repos.updateCaHoc(clone) == true)
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
