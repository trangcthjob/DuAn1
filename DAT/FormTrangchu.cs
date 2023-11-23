using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAT
{
    public partial class FormTrangchu : Form
    {
        public string Username { get; set; } = string.Empty;
        public FormTrangchu()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void OpenForm(Form formOpen)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formOpen;
            formOpen.TopLevel = false;
            formOpen.Dock = DockStyle.Fill;
            panelShow.Controls.Add(activeForm);
            panelShow.Tag = activeForm;
            panelShow.BringToFront();
            formOpen.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.Gray;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            FormThongTinCaNhan formInfomation = new FormThongTinCaNhan();
            formInfomation.Username = Username;
            formInfomation.showFormChangePassword += OpenForm;
            formInfomation.ChangeAvatarMenu += (fileName) =>
            {
                pic_avatar.Image = new Bitmap(fileName);
            };
            OpenForm(formInfomation);
        }

        private void FormTrangchu_Load(object sender, EventArgs e)
        {
            // Hiển thị avatar
            var account = new DAT_Services.Services.AccountServices().GetAccount(Username);
            if (!string.IsNullOrEmpty(account.Avatar))
            {
                pic_avatar.Image = new Bitmap(account.Avatar);
            }
        }
    }
}
