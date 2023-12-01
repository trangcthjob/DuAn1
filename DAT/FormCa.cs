using DAT_Services.IServices;
using DAT_Services.Services;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT
{
    public partial class FormCa : Form
    {
        public readonly ICaService _caHocService;
        public readonly ISinhVienService _sinhVienService;
        List<Ca> listCa = new List<Ca>();
        List<SinhVien> listSinhVien = new List<SinhVien>();
        private bool isAddColumn = false;

        public FormCa()
        {
            InitializeComponent();
            _caHocService = new CaServices();
            _sinhVienService = new SinhVienService();
        }
        

        
    }
}
