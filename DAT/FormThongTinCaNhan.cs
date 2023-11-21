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
        public FormThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Form changePasswordform = new FormDoiMatKhau();
            showFormChangePassword.Invoke(changePasswordform);
        }
    }
}
