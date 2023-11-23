using DAT_Services.IServices;
using DAT_Services.Services;
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
    public partial class FormDangNhap : Form
    {
        // AccountServices
        private readonly IAccountServices _accountServices = new AccountServices();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            // Đăng kí tài khoản
            FormDangKy formDangKy = new FormDangKy();
            this.Hide();
            formDangKy.ShowDialog();
            formDangKy = null;
            this.Show();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            // Đăng nhập
            if (_accountServices.Login(txt_username.Text,txt_matkhau.Text))
            {
                // Hiện trang chủ
                FormTrangchu formTrangChu = new FormTrangchu();
                formTrangChu.Username = txt_username.Text;
                this.Hide();
                formTrangChu.ShowDialog();
                formTrangChu = null;
                this.Close();

            }
            else
            {
                //Thông tin tài khoản mật khẩu không chính xác
                MessageBox.Show("Thông tin tài khoản mật khẩu không chính xác","Thông báo");
            }
        }
    }
}
