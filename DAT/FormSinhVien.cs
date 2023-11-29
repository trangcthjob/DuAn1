using DAT_Services.IServices;
using DAT_Services.Services;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT
{
    public partial class FormSinhVien : Form
    {
        private readonly IChuyenNganhService _chuyenNganhService;
        // Sinh viên
        private readonly ISinhVienService _sinhVienService;
        List<ChuyenNganh> listChuyenNganh = new List<ChuyenNganh>();
        List<SinhVien> listSinhVien = new List<SinhVien>();
        private bool isAddColumn = false;
        public FormSinhVien()
        {
            InitializeComponent();
            _sinhVienService = new SinhVienService();
            // Chuyên ngành
            _chuyenNganhService = new ChuyenNganhService();
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            // Mở form thêm sinh viên
            FormAddUpdateSinhVien formAddSinhVien = new FormAddUpdateSinhVien();
            formAddSinhVien.ShowDialog();
            // clear row
            dgv_sinhVien.Rows.Clear();
            listChuyenNganh = _chuyenNganhService.GetListChuyenNganh();
            listSinhVien = _sinhVienService.GetListSinhVien();
            FormSinhVien_Load(null, null);
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            if (listSinhVien.Count == 0 && listChuyenNganh.Count == 0)
            {
                // get list
                listChuyenNganh = _chuyenNganhService.GetListChuyenNganh();
                listSinhVien = _sinhVienService.GetListSinhVien();
            }
            // lấy danh sách chuyên ngành
            // lấy danh sách sinh viên
            // join 2 bảng sinh viên và chuyên ngành
            // lấy ra tên chuyên ngành
            // hiển thị lên datagridview
            // hiển thị avatar sinh viên lên datagridview
            // hiển thị tên chuyên ngành lên datagridview
            // Lấy danh sách sinh viên
            // Lấy danh sách chuyên ngành
            // thêm lựa chọn tất cả vào chuyên ngành
            listChuyenNganh.Add( new ChuyenNganh()
            {
                Id = Guid.Empty,
                TenChuyenNganh = "Tất cả"
            });
            cb_chuyenNganh.DataSource = listChuyenNganh;
            cb_chuyenNganh.DisplayMember = "TenChuyenNganh";
            cb_chuyenNganh.ValueMember = "Id";
            // thêm lựa chọn tât cả vào combobox
            // Join 2 bảng sinh viên và chuyên ngành
            var listSinhVienJoin = from sv in listSinhVien
                                   join cn in listChuyenNganh
                                   on sv.ChuyenNganhId equals cn.Id
                                   select new
                                   {
                                       Avatar = new Bitmap(sv.Avatar),
                                       Id = sv.Id,
                                       MaSinhVien = sv.MaSinhVien,
                                       HoVaTen = sv.HoVaTen,
                                       NgaySinh = sv.NgaySinh,
                                       GioiTinh = sv.GioiTinh,
                                       DiaChi = sv.DiaChi,
                                       SoDienThoai = sv.SoDienThoai,
                                       Email = sv.Email,
                                       TenChuyenNganh = cn.TenChuyenNganh
                                   };
            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            //set size header
            dgv_sinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            imageCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            // set size
            dgv_sinhVien.RowTemplate.Height = 150;
            if (!isAddColumn)
            {
                isAddColumn = true;
                dgv_sinhVien.Columns.Add(imageCol);
                // Thêm các cột vào datagridview
                dgv_sinhVien.Columns.Add("Id", "Id");
                // ẩn cột id
                dgv_sinhVien.Columns["Id"].Visible = false;
                dgv_sinhVien.Columns.Add("MaSinhVien", "Mã sinh viên");
                dgv_sinhVien.Columns.Add("HoVaTen", "Họ và tên");
                dgv_sinhVien.Columns.Add("NgaySinh", "Ngày sinh");
                dgv_sinhVien.Columns.Add("GioiTinh", "Giới tính");
                dgv_sinhVien.Columns.Add("DiaChi", "Địa chỉ");
                dgv_sinhVien.Columns.Add("SoDienThoai", "Số điện thoại");
                dgv_sinhVien.Columns.Add("Email", "Email");
                dgv_sinhVien.Columns.Add("TenChuyenNganh", "Chuyên ngành");
            }
            // duyệt qua danh sách sinh viên
            foreach (var item in listSinhVienJoin)
            {
                dgv_sinhVien.Rows.Add(item.Avatar, item.Id, item.MaSinhVien, item.HoVaTen, item.NgaySinh.ToString("dd/MM/yyyy"), item.GioiTinh, item.DiaChi, item.SoDienThoai, item.Email, item.TenChuyenNganh);
            }
            // tự dộng co dãn cột
            dgv_sinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // ẩn dòng cuối cùng
            dgv_sinhVien.AllowUserToAddRows = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // kiểm tra xem người dùng đã chọn sinh viên chưa
            if (dgv_sinhVien.SelectedRows.Count > 0)
            {
                // lấy id sinh viên
                var id = dgv_sinhVien.SelectedRows[0].Cells["Id"].Value.ToString();
                // mở form update sinh viên
                FormAddUpdateSinhVien formUpdateSinhVien = new FormAddUpdateSinhVien();
                formUpdateSinhVien.IdSinhVien = Guid.Parse(id);
                formUpdateSinhVien.isUpdate = true;
                formUpdateSinhVien.ShowDialog();
                // clear row
                dgv_sinhVien.Rows.Clear();
                listChuyenNganh = _chuyenNganhService.GetListChuyenNganh();
                listSinhVien = _sinhVienService.GetListSinhVien();
                FormSinhVien_Load(null, null);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // hiển thị messagebox xác nhận xóa
            // nếu ok thì xóa
            // nếu cancel thì không xóa
            if (dgv_sinhVien.SelectedRows.Count > 0)
            {
                // lấy id sinh viên
                var id = dgv_sinhVien.SelectedRows[0].Cells["Id"].Value.ToString();
                // hiển thị messagebox xác nhận xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    // xóa sinh viên
                    if (_sinhVienService.DeleteSinhVien(Guid.Parse(id)))
                    {
                        MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // clear row
                        dgv_sinhVien.Rows.Clear();
                        FormSinhVien_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa sinh viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_TimkiemSV_TextChanged(object sender, EventArgs e)
        {
            //tìm kiếm sinh viên theo tên
            //tìm kiếm theo mã sinh viên
            listSinhVien = _sinhVienService.SearchSinhVien(txt_TimkiemSV.Text, Guid.Parse(cb_chuyenNganh.SelectedValue.ToString()));
            dgv_sinhVien.Rows.Clear();
            FormSinhVien_Load(null, null);

        }

        private void cb_chuyenNganh_SelectedValueChanged(object sender, EventArgs e)
        {
            // try parse guid
            // nếu thành công thì tìm kiếm
            // nếu không thành công thì không làm gì cả
            if (Guid.TryParse(cb_chuyenNganh.SelectedValue.ToString(), out Guid result))
            {
                //tìm kiếm theo mã sinh viên
                listSinhVien = _sinhVienService.SearchSinhVien(txt_TimkiemSV.Text, Guid.Parse(cb_chuyenNganh.SelectedValue.ToString()));
                dgv_sinhVien.Rows.Clear();
                FormSinhVien_Load(null, null);
            }
        }
    }
}
