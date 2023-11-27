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
    public class ChuyenNganhService : IChuyenNganhService
    {
        // Repository
        private readonly IChuyenNganhRepository _repository;
        public ChuyenNganhService()
        {
            _repository = new ChuyenNganhRepository();
        }
        // Lấy danh sách
        public List<ChuyenNganh> GetListChuyenNganh()
        {
            return _repository.GetListChuyenNganh();
        }
    }
}
