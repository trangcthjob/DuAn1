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
    public partial class FormDoiMatKhau : Form
    {
        //username
        public string Username { get; set; } = string.Empty;
        // Account Services
        private readonly IAccountServices _accountServices = new AccountServices();
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }



        private void pic_anmatkhau_Click(object sender, EventArgs e)
        {
            if (!txt_matkhauhientai.UseSystemPasswordChar)
            {
                pic_hienmatkhau.BringToFront();
                txt_matkhauhientai.UseSystemPasswordChar = true;
            }
        }

        private void pic_hienmatkhau_Click(object sender, EventArgs e)
        {
            if (txt_matkhauhientai.UseSystemPasswordChar)
            {
                txt_matkhauhientai.PasswordChar = '\0';
                pic_anmatkhau.BringToFront();
                txt_matkhauhientai.UseSystemPasswordChar = false;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            // Đổi mật khẩu
            if (_accountServices.ChangePassword(Username, txt_matkhauhientai.Text, txt_matkhaumoi.Text, txt_matkhaumoi2.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác", "Thông báo");
            }
        }
    }
}
