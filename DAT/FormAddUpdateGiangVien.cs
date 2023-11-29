using DAT_Services.IServices;
using DAT_Services.Services;
using Domain.Models;
using Infrastructure.Enum;
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
    public partial class FormAddUpdateGiangVien : Form
    {
        // Khai báo các service cần dùng
        private readonly IChuyenNganhService _chuyenNganhService;
        // Giảng viên
        private readonly IGiangVienService _giangVienService;
        // Lưu đường dẫn ảnh
        private string _imagePath;
        public bool isUpdate = false;
        public Guid IdGiangVien = Guid.Empty;
        // Khởi tạo các service
        public FormAddUpdateGiangVien()
        {
            _chuyenNganhService = new ChuyenNganhService();
            _giangVienService = new GiangVienService();
            InitializeComponent();

        }
        // lấy danh sách chuyên ngành
        private void GetListChuyenNganh()
        {
            // Lấy danh sách chuyên ngành
            List<ChuyenNganh> listChuyenNganh = _chuyenNganhService.GetListChuyenNganh();
            // Thêm vào combobox
            // hiện tên chuyên ngành
            // giá trị là Id chuyên ngành
            cb_chuyenNganh.DataSource = listChuyenNganh;
            cb_chuyenNganh.DisplayMember = "TenChuyenNganh";
            cb_chuyenNganh.ValueMember = "Id";
        }

        private void FormAddUpdateGiangVien_Load(object sender, EventArgs e)
        {
            GetListChuyenNganh();
            //nếu là update
            //Thì hiển thị thông tin giảng viên
            if (isUpdate && IdGiangVien != Guid.Empty)
            {
                btn_reset_Click(null, null);
                // Lấy thông tin giảng viên
                GiangVien giangVien = _giangVienService.GetGiangVien(IdGiangVien);
                // Hiển thị thông tin giảng viên lên form
                txt_hoTen.Text = giangVien.TenGiangVien;
                txt_diaChi.Text = giangVien.DiaChi;
                txt_sdt.Text = giangVien.SoDienThoai;
                dtp_ngaySinh.Value = giangVien.NgaySinh;
                cb_chuyenNganh.SelectedValue = giangVien.ChuyenNganhId;
                if (!string.IsNullOrEmpty(giangVien.Avatar))
                {
                    pic_anhdaidien.Image = new Bitmap(giangVien.Avatar);
                    _imagePath = giangVien.Avatar;
                }
                if (giangVien.GioiTinh == GenderEnum.Men)
                {
                    rdo_nam.Checked = true;
                }
                else if (giangVien.GioiTinh == GenderEnum.Women)
                {
                    rdo_nu.Checked = true;
                }
                else
                {
                    rdo_khongtietlo.Checked = true;
                }
                btn_addupdate.Text = "Cập nhật";
                lb_add.Text = "Cập nhật giảng viên";


            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            // clear các textbox
            txt_hoTen.Text = string.Empty;
            txt_diaChi.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            // clear ảnh đại diện
            pic_anhdaidien.Image = null;
            // clear dtp ngày sinh
            dtp_ngaySinh.Value = DateTime.Now;
            // clear combobox
            cb_chuyenNganh.SelectedIndex = 0;
            // clear radiobutton
            rdo_nam.Checked = true;

        }

        private void btn_addupdate_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                //lấy thông tin giảng viên
                GiangVien giangVien = new GiangVien();
                giangVien.TenGiangVien = txt_hoTen.Text;
                giangVien.DiaChi = txt_diaChi.Text;
                giangVien.SoDienThoai = txt_sdt.Text;
                giangVien.NgaySinh = dtp_ngaySinh.Value;
                giangVien.ChuyenNganhId = Guid.Parse(cb_chuyenNganh.SelectedValue.ToString());
                giangVien.Avatar = _imagePath;
                giangVien.GioiTinh = GetGender();
                // Mã giảng viên
                giangVien.MaGiangVien = GetMaGV();
                //EMail
                giangVien.Email = GetEmail();
                // Thêm giảng viên
                if (_giangVienService.AddGiangVien(giangVien))
                {
                    MessageBox.Show("Thêm giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm giảng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // cập nhật giảng viên
                // lấy thông tin giảng viên
                GiangVien giangVien = _giangVienService.GetGiangVien(IdGiangVien);
                giangVien.TenGiangVien = txt_hoTen.Text;
                giangVien.DiaChi = txt_diaChi.Text;
                giangVien.SoDienThoai = txt_sdt.Text;
                giangVien.NgaySinh = dtp_ngaySinh.Value;
                giangVien.ChuyenNganhId = Guid.Parse(cb_chuyenNganh.SelectedValue.ToString());
                giangVien.Avatar = _imagePath;
                giangVien.GioiTinh = GetGender();
                // Mã giảng viên
                giangVien.MaGiangVien = GetMaGV();
                //EMail
                giangVien.Email = GetEmail();
                // Cập nhật giảng viên
                if (_giangVienService.UpdateGiangVien(giangVien))
                {
                    MessageBox.Show("Cập nhật giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật giảng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // gen mã giảng viên
        // lấy mã chuyên ngành của chuyên ngành đang được chọn trong combobox
        // lấy 2 ký tự đầu của chuyên ngành
        // cộng số lượng giảng viên của chuyên ngành đó
        // thêm vào mã giảng viên
        private string GetMaGV()
        {
            // Lấy mã chuyên ngành
            var maChuyenNganh = _chuyenNganhService.GetListChuyenNganh().FirstOrDefault(c => c.Id.ToString() == cb_chuyenNganh.SelectedValue.ToString());
            // Lấy số lượng giảng viên của chuyên ngành đó
            var count = _giangVienService.GetListGiangVien().Where(x => x.ChuyenNganhId.ToString() == cb_chuyenNganh.SelectedValue.ToString()).Count();
            // Thêm vào mã giảng viên
            var result = "GV" + maChuyenNganh.MaChuyenNganh + (count + 1).ToString();
            return result;
        }
        // lấy giới tính đang được chọn
        private GenderEnum GetGender()
        {
            // kiểm tra 3 checkbox
            // rdo_nam.Checked
            // rdo_nu.Checked
            // rdo_khongTietLo.Checked
            if (rdo_nam.Checked)
            {
                return GenderEnum.Men;
            }
            else if (rdo_nu.Checked)
            {
                return GenderEnum.Women;
            }
            else
            {
                return GenderEnum.NoShare;
            }
        }
        // gen email
        // lấy tên giảng viên
        // cắt tên bởi dấu cách
        // lấy ký tự đầu của các từ
        // thêm vào tên chuyên ngành
        // thêm vào @fpt.edu
        // thêm vào .com
        private string GetEmail()
        {
            // Lấy tên sinh viên
            var name = txt_hoTen.Text;
            // Cắt tên bởi dấu cách
            var arrName = name.Split(' ');
            // Lấy ký tự đầu của các từ
            var result = arrName.LastOrDefault();
            // bỏ phần từ cuối cùng
            arrName = arrName.Take(arrName.Count() - 1).ToArray();
            foreach (var item in arrName)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    result += item.Trim().Substring(0, 1);
                }
            }
            // Thêm vào mã chuyên ngành
            result += cb_chuyenNganh.SelectedValue.ToString().Substring(0, 2);
            // Thêm vào @fpt.edu
            result += "@fe.edu";
            // Thêm vào .com
            result += ".com";
            return result;
        }

        private void btn_avt_Click(object sender, EventArgs e)
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
                _imagePath = openFileDialog.FileName;
            }
        }
    }
}
