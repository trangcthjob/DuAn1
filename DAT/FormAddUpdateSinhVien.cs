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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAT
{
    public partial class FormAddUpdateSinhVien : Form
    {
        // Khai báo các service cần dùng
        private readonly IChuyenNganhService _chuyenNganhService;
        // Sinh viên
        private readonly ISinhVienService _sinhVienService;
        // Lưu đường dẫn ảnh
        private string _imagePath;
        public bool isUpdate = false;
        public Guid IdSinhVien = Guid.Empty;
        // Khởi tạo các service
        public FormAddUpdateSinhVien()
        {
            _chuyenNganhService = new ChuyenNganhService();
            _sinhVienService = new SinhVienService();
            InitializeComponent();
            // Lấy danh sách chuyên ngành
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
        private  async void btn_add_Click(object sender, EventArgs e)
        {
            if (!isUpdate)
            {
                // Lấy thông tin sinh viên
                SinhVien sinhVien = new SinhVien();
                sinhVien.MaSinhVien = GetMaSinhVien();
                sinhVien.HoVaTen = txt_hoTen.Text;
                sinhVien.NgaySinh = dtp_ngaySinh.Value;
                sinhVien.DiaChi = txt_diaChi.Text;
                sinhVien.SoDienThoai = txt_sdt.Text;
                sinhVien.Email = GetEmail();
                sinhVien.GioiTinh = GetGender();
                sinhVien.ChuyenNganhId = Guid.Parse(cb_chuyenNganh.SelectedValue.ToString());
                sinhVien.Avatar = _imagePath;
                // Thêm sinh viên
                if (_sinhVienService.AddSinhVien(sinhVien))
                {
                    MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Lấy thông tin sinh viên
                SinhVien sinhVien = new SinhVien();
                sinhVien.Id = IdSinhVien;
                sinhVien.MaSinhVien = GetMaSinhVien();
                sinhVien.HoVaTen = txt_hoTen.Text;
                sinhVien.NgaySinh = dtp_ngaySinh.Value;
                sinhVien.DiaChi = txt_diaChi.Text;
                sinhVien.SoDienThoai = txt_sdt.Text;
                sinhVien.Email = GetEmail();
                sinhVien.GioiTinh = GetGender();
                sinhVien.ChuyenNganhId = Guid.Parse(cb_chuyenNganh.SelectedValue.ToString());
                sinhVien.Avatar = _imagePath;
                // Thêm sinh viên
                if ( await _sinhVienService.UpdateSinhVien(sinhVien))
                {
                    MessageBox.Show("Cập nhật sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật sinh viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormAddSinhVien_Load(object sender, EventArgs e)
        {
            GetListChuyenNganh();
            // nếu là update
            // thì hiển thị thông tin sinh viên
            if (isUpdate && IdSinhVien != Guid.Empty)
            {
                btn_reset_Click(null, null);
                // Lấy thông tin sinh viên
                var sinhVien = _sinhVienService.GetSinhVien(IdSinhVien);
                // Hiển thị thông tin sinh viên
                txt_hoTen.Text = sinhVien.HoVaTen;
                txt_diaChi.Text = sinhVien.DiaChi;
                txt_sdt.Text = sinhVien.SoDienThoai;
                dtp_ngaySinh.Value = sinhVien.NgaySinh;
                cb_chuyenNganh.SelectedValue = sinhVien.ChuyenNganhId;
                // Hiển thị ảnh đại diện
                if (!string.IsNullOrEmpty(sinhVien.Avatar))
                {
                    pic_anhdaidien.Image = new Bitmap(sinhVien.Avatar);
                    _imagePath = sinhVien.Avatar;
                }
                // nếu là nam thì check vào nam
                // nếu là nữ thì check vào nữ
                // nếu là không tiết lộ thì check vào không tiết lộ
                if (sinhVien.GioiTinh == GenderEnum.Men)
                {
                    rdo_nam.Checked = true;
                }
                else if (sinhVien.GioiTinh == GenderEnum.Women)
                {
                    rdo_nu.Checked = true;
                }
                else
                {
                    rdo_khongtietlo.Checked = true;
                }
                btn_addupdate.Text = "Cập nhật";
                lb_add.Text = "Cập nhật sinh viên";

            }
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
        // gen mã sinh viên
        // lấy mã chuyên ngành của chuyên ngành đang được chọn trong combobox
        // lấy 2 ký tự đầu của chuyên ngành
        // cộng số lượng sinh viên của chuyên ngành đó
        // thêm vào mã sinh viên
        private string GetMaSinhVien()
        {
            // Lấy mã chuyên ngành
            var maChuyenNganh = _chuyenNganhService.GetListChuyenNganh().FirstOrDefault(c => c.Id.ToString() == cb_chuyenNganh.SelectedValue.ToString());
            // Lấy số lượng sinh viên của chuyên ngành đó
            var count = _sinhVienService.GetListSinhVien().Where(x => x.ChuyenNganhId.ToString() == cb_chuyenNganh.SelectedValue.ToString()).Count();
            // Thêm vào mã sinh viên
            var result = maChuyenNganh.MaChuyenNganh + (count + 1).ToString();
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
        // lấy tên sinh viên
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
            result += "@fpt.edu";
            // Thêm vào .com
            result += ".com";
            return result;
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
    }
}
