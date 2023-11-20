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
            FormDangNhap test = new FormDangNhap();
            OpenForm(test);
        }
    }
}
