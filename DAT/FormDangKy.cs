using DAT_Services.IServices;
using DAT_Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT
{
    public partial class FormDangKy : Form
    {
        // AccountServices
        private readonly IAccountServices _accountServices = new AccountServices();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void cb_policy_CheckedChanged(object sender, EventArgs e)
        {
            // nếu đã điền đầy đủ thông tin và đã checked thì button đăng kí enable
            EnableButton();
        }
        // enable button đăng kí
        private void EnableButton()
        {
            if (!string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_password.Text) && !string.IsNullOrEmpty(txt_repassword.Text) && cb_policy.Checked)
            {
                btn_register.Enabled = true;
            }
            else
            {
                btn_register.Enabled = false;
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txt_repassword_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Đăng kí tài khoản
            // nếu đăng kí thành công thì đưa ra messagebox thông báo
            // nếu đăng kí thất bại thì đưa ra messagebox thông báo
            var username = txt_username.Text;
            var password = txt_password.Text;
            var repassword = txt_repassword.Text;
            var result = _accountServices.Register(username, password, repassword);
            if (result)
            {
                MessageBox.Show("Đăng kí thành công");
                // mở form đăng nhập
                var formDangNhap = new FormDangNhap();
                this.Close();
                // đóng form đăng kí
            }
            else
            {
                MessageBox.Show("Đăng kí thất bại");
            }
        }
    }
}
