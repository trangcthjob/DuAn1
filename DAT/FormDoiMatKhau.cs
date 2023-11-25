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
            var reusult = _accountServices.ChangePassword(Username, txt_matkhauhientai.Text, txt_matkhaumoi.Text, txt_matkhaumoi2.Text);
            MessageBox.Show(reusult, "Thông báo");
        }

        private void pic_anmatkhau2_Click(object sender, EventArgs e)
        {
            if (!txt_matkhaumoi.UseSystemPasswordChar)
            {
                pic_hienmatkhau2.BringToFront();
                txt_matkhaumoi.UseSystemPasswordChar = true;
            }
        }

        private void pic_hienmatkhau2_Click(object sender, EventArgs e)
        {
            if (txt_matkhaumoi.UseSystemPasswordChar)
            {
                txt_matkhaumoi.PasswordChar = '\0';
                pic_anmatkhau2.BringToFront();
                txt_matkhaumoi.UseSystemPasswordChar = false;
            }
        }

        private void pic_anmatkhau3_Click(object sender, EventArgs e)
        {
            if (!txt_matkhaumoi2.UseSystemPasswordChar)
            {
                pic_hienmatkhau3.BringToFront();
                txt_matkhaumoi2.UseSystemPasswordChar = true;
            }
        }

        private void pic_hienmatkhau3_Click(object sender, EventArgs e)
        {
            if (txt_matkhaumoi2.UseSystemPasswordChar)
            {
                txt_matkhaumoi2.PasswordChar = '\0';
                pic_anmatkhau3.BringToFront();
                txt_matkhaumoi2.UseSystemPasswordChar = false;
            }
        }
    }
}
