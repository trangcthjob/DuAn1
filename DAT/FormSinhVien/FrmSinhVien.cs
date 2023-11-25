using DAT.FormSinhVien;
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
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
            CustomDesignFrmSV();
        }

        private void CustomDesignFrmSV()
        {
            pn_LichHoc.Visible = false;
            pn_Diem.Visible = false;
            pn_LichHoc.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pn_Diem.Visible == true)
            {
                pn_Diem.Visible = false;
            };
            if (pn_LichHoc.Visible == true)
            {
                pn_LichHoc.Visible = false;
            };
            if (pn_DichVu.Visible == true)
            {
                pn_DichVu.Visible = false;
            };

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_ChildForm.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnDiemDanhSV_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pn_ThongBao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {

        }

        private void btnControlLichHoc_Click(object sender, EventArgs e)
        {
            showSubMenu(pn_LichHoc);
        }

        private void btnThayDoiLichHoc_Click(object sender, EventArgs e)
        {
            //// 
            ///


            hideSubMenu();
        }

        private void btnLichHoc_Click(object sender, EventArgs e)
        {



            hideSubMenu();
        }

        private void btnLichThi_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnControlDiem_Click(object sender, EventArgs e)
        {
            showSubMenu(pn_Diem);
        }

        private void btnBangDiemTheoKy_Click(object sender, EventArgs e)
        {


            hideSubMenu();
        }

        private void btnLichSuHoc_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btnControlDichVu_Click(object sender, EventArgs e)
        {
            showSubMenu(pn_DichVu);
        }

        private void btnDangKiDV_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btnDVDaDangKi_Click(object sender, EventArgs e)
        {
            hideSubMenu();

        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            openChildForm(new Diemdanh());
        }
    }

}
