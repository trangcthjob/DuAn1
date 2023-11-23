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
    public partial class FormThongTinCaNhan : Form
    {
        public delegate void ShowFormChangePassword(Form form);
        public ShowFormChangePassword showFormChangePassword { get; set; }  
        public delegate void ChangeAvatar(string fileName);
        public ChangeAvatar ChangeAvatarMenu { get; set; }
        // Account Services
        private readonly IAccountServices _accountServices = new AccountServices();
        // username
        public string Username { get; set; } = string.Empty;
        public FormThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau changePasswordform = new FormDoiMatKhau();
            changePasswordform.Username = Username;
            showFormChangePassword.Invoke(changePasswordform);
        }



        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            // lấy thông tin tài khoản
            var account = _accountServices.GetAccount(Username);
            // hiển thị thông tin tài khoản
            txt_tenhienthi.Text = account.DisplayName;
            txt_email.Text = account.Email;
            txt_sdt.Text = account.Phone;
            // Hiển thị ảnh đại diện
            if (!string.IsNullOrEmpty(account.Avatar))
            {
                pic_anhdaidien.Image = new Bitmap(account.Avatar);
            }
            // Giới tính
            switch (account.Gender)
            {
                case Infrastructure.Enum.GenderEnum.Men:
                    rdo_nam.Checked = true;
                    break;
                case Infrastructure.Enum.GenderEnum.Women:
                    rdo_nu.Checked = true;
                    break;
                case Infrastructure.Enum.GenderEnum.NoShare:
                    rdo_khongTietLo.Checked = true;
                    break;
                default:
                    break;
            }

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            var acccount = _accountServices.GetAccount(Username);
            acccount.DisplayName = txt_tenhienthi.Text;
            acccount.Email = txt_email.Text;
            acccount.Phone = txt_sdt.Text;
            // Giới tính
            if (rdo_nam.Checked)
            {
                // Nam 
                acccount.Gender = Infrastructure.Enum.GenderEnum.Men;

            }
            else if (rdo_nu.Checked)
            {
                // Nữ
                acccount.Gender = Infrastructure.Enum.GenderEnum.Women;
            }
            else
            {
                acccount.Gender = Infrastructure.Enum.GenderEnum.NoShare;
            }
            var result = _accountServices.EditAccount(acccount);
            if (result)
            {
                MessageBox.Show("Lưu thành công");
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Mở file dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // Xem trước ảnh
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Hiển thị ảnh
                pic_anhdaidien.Image = new Bitmap(openFileDialog.FileName);
                // Lưu đường dẫn ảnh
                var account = _accountServices.GetAccount(Username);
                account.Avatar = openFileDialog.FileName;
                var result = _accountServices.EditAccount(account);
                if (result)
                {
                    ChangeAvatarMenu.Invoke(account.Avatar);
                    MessageBox.Show("Thay đổi ảnh đại diện thành công");
                }
                else
                {
                    MessageBox.Show("Thay đổi ảnh đại diện thất bại");
                }
            }
        }
    }
}
