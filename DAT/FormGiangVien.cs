using DAT_Services.IServices;
using DAT_Services.Services;
using Domain.Models;
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
    public partial class FormGiangVien : Form
    {
        public readonly IChuyenNganhService _chuyenNganhgService;
        public readonly IGiangVienService _giangVienService;
        private bool isAddColumn = false;
        public FormGiangVien()
        {
            InitializeComponent();
            _chuyenNganhgService = new ChuyenNganhService();
            _giangVienService = new GiangVienService();
        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            // lấy danh sách chuyên ngành
            // lấy danh sách giảng viên
            // join 2 bảng giảng viên và chuyên ngành
            // lấy ra tên chuyên ngành
            // hiển thị lên datagridview
            // hiển thị avatar giảng viên lên datagridview
            // hiển thị tên chuyên ngành lên datagridview
            // Lấy danh sách giảng viên
            List<GiangVien> listGiangVien = _giangVienService.GetListGiangVien();
            // Lấy danh sách chuyên ngành
            List<ChuyenNganh> listChuyenNganh = _chuyenNganhgService.GetListChuyenNganh();
            cb_chuyenNganh.DataSource = listChuyenNganh;
            cb_chuyenNganh.DisplayMember = "TenChuyenNganh";
            cb_chuyenNganh.ValueMember = "Id";
            // Join 2 bảng giảng viên và chuyên ngành
            var listGiangVienJoin = from gv in listGiangVien
                                    join cn in listChuyenNganh
                                    on gv.ChuyenNganhId equals cn.Id
                                    select new
                                    {
                                        Avatar = new Bitmap(gv.Avatar),
                                        Id = gv.Id,
                                        MaGiangVien = gv.MaGiangVien,
                                        TenGiangVien = gv.TenGiangVien,
                                        GioiTinh = gv.GioiTinh,
                                        NgaySinh = gv.NgaySinh,
                                        DiaChi = gv.DiaChi,
                                        Email = gv.Email,
                                        SoDienThoai = gv.SoDienThoai,
                                        TenChuyenNganh = cn.TenChuyenNganh
                                    };
            // Hiển thị avatar giảng viên lên datagridview
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //set size header
            dgv_GiangVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // set size
            dgv_GiangVien.RowTemplate.Height = 150;
            // nếu chưa thêm cột thì thêm cột
            if (!isAddColumn)
            {
                isAddColumn = true;
                dgv_GiangVien.Columns.Add(imageColumn);
                // Thêm các cột vào datagridview
                dgv_GiangVien.Columns.Add("Id", "Id");
                // ẩn cột id
                dgv_GiangVien.Columns["Id"].Visible = false;
                // Avatar
                dgv_GiangVien.Columns.Add("MaGiangVien", "Mã giảng viên");
                dgv_GiangVien.Columns.Add("HoVaTen", "Họ và tên");
                dgv_GiangVien.Columns.Add("NgaySinh", "Ngày sinh");
                dgv_GiangVien.Columns.Add("GioiTinh", "Giới tính");
                dgv_GiangVien.Columns.Add("DiaChi", "Địa chỉ");
                dgv_GiangVien.Columns.Add("SoDienThoai", "Số điện thoại");
                dgv_GiangVien.Columns.Add("Email", "Email");
                dgv_GiangVien.Columns.Add("TenChuyenNganh", "Chuyên ngành");
            }
            // duyệt qua danh sách giảng viên
            foreach (var item in listGiangVienJoin)
            {
                // hiển thị avatar giảng viên lên datagridview
                dgv_GiangVien.Rows.Add(item.Avatar, item.Id,item.MaGiangVien, item.TenGiangVien, item.NgaySinh.ToString("dd/MM/yyyy"), item.GioiTinh, item.DiaChi, item.SoDienThoai, item.Email, item.TenChuyenNganh);
            }
            // tự dộng co dãn cột
            dgv_GiangVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // ẩn dòng cuối cùng
            dgv_GiangVien.AllowUserToAddRows = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //mở form thêm giảng viên
            FormAddUpdateGiangVien formThemGiangVien = new FormAddUpdateGiangVien();
            formThemGiangVien.ShowDialog();
            //clear row
            dgv_GiangVien.Rows.Clear();
            //load lại danh sách giảng viên
            FormGiangVien_Load(null, null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //kiểm tra xem người dùng đã chọn giảng viên chưa
            if (dgv_GiangVien.SelectedRows.Count > 0)
            {
                //lấy id giảng viên
                var id = dgv_GiangVien.SelectedRows[0].Cells["Id"].Value.ToString();
                //mở form update giảng viên
                FormAddUpdateGiangVien formUpdateGiangVien = new FormAddUpdateGiangVien();
                formUpdateGiangVien.IdGiangVien = Guid.Parse(id);
                formUpdateGiangVien.isUpdate = true;
                formUpdateGiangVien.ShowDialog();
                //clear row
                dgv_GiangVien.Rows.Clear();
                //load lại danh sách giảng viên
                FormGiangVien_Load(null, null);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //hiển thị messagebox xác nhận xóa
            //nếu ok thì xóa
            //nếu cancel thì không xóa
            if (dgv_GiangVien.SelectedRows.Count > 0)
            {
                //lấy id giảng viên
                var id = dgv_GiangVien.SelectedRows[0].Cells["Id"].Value.ToString();
                //hiển thị messagebox xác nhận xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa giảng viên này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    //xóa giảng viên
                    if (_giangVienService.DeleteGiangVien(Guid.Parse(id)))
                    {
                        MessageBox.Show("Xóa giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear row
                        dgv_GiangVien.Rows.Clear();
                        //load lại danh sách giảng viên
                        FormGiangVien_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa giảng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
