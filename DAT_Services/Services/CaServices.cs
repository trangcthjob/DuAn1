using DAT_Services.IRepository;
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
    public class CaServices : ICaService
    {
        private readonly ICaRepository _caHocRepository;
        public CaServices()
        {
            _caHocRepository = new CaRepository();
        }

        public bool AddCa(Ca caHoc)
        {
            return _caHocRepository.AddCa(caHoc);
        }

        public bool DeleteCa(string nameCaHoc)
        {
            return _caHocRepository.DeleteCa(nameCaHoc);
        }

        public List<Ca> GetListCa()
        {
            return _caHocRepository.GetListCa();
        }

        public List<Ca> SearchCa(string stringSearch, string nameCaHoc)
        {
            return _caHocRepository.SearchCa(stringSearch, nameCaHoc);

        }

        public bool UpdateCa(Ca caHoc)
        {
            return _caHocRepository.UpdateCa(caHoc);
        }
    }
}
