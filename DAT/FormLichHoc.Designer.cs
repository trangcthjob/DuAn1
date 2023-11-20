namespace DAT
{
    partial class FormLichHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            dtgLichHoc = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtMa = new TextBox();
            txtNgayHoc = new TextBox();
            txtSoSv = new TextBox();
            cmbxCaHoc = new ComboBox();
            cmbxGiangVien = new ComboBox();
            cmbxMonHoc = new ComboBox();
            cmbxLopHoc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgLichHoc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 29);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Lịch Học Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 73);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 111);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "lớp học";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 152);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "ca học";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 196);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Môn học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 246);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "Giảng viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 290);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "ngày học";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 349);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 8;
            label9.Text = "số SV";
            // 
            // dtgLichHoc
            // 
            dtgLichHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLichHoc.Location = new Point(31, 398);
            dtgLichHoc.Name = "dtgLichHoc";
            dtgLichHoc.RowHeadersWidth = 51;
            dtgLichHoc.RowTemplate.Height = 29;
            dtgLichHoc.Size = new Size(655, 188);
            dtgLichHoc.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(555, 66);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(144, 53);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(555, 136);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(144, 53);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(555, 213);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(144, 53);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(105, 66);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(357, 27);
            txtMa.TabIndex = 13;
            // 
            // txtNgayHoc
            // 
            txtNgayHoc.Location = new Point(106, 287);
            txtNgayHoc.Name = "txtNgayHoc";
            txtNgayHoc.Size = new Size(356, 27);
            txtNgayHoc.TabIndex = 18;
            // 
            // txtSoSv
            // 
            txtSoSv.Location = new Point(104, 349);
            txtSoSv.Name = "txtSoSv";
            txtSoSv.Size = new Size(357, 27);
            txtSoSv.TabIndex = 19;
            // 
            // cmbxCaHoc
            // 
            cmbxCaHoc.FormattingEnabled = true;
            cmbxCaHoc.Location = new Point(106, 144);
            cmbxCaHoc.Name = "cmbxCaHoc";
            cmbxCaHoc.Size = new Size(245, 28);
            cmbxCaHoc.TabIndex = 21;
            // 
            // cmbxGiangVien
            // 
            cmbxGiangVien.FormattingEnabled = true;
            cmbxGiangVien.Location = new Point(106, 243);
            cmbxGiangVien.Name = "cmbxGiangVien";
            cmbxGiangVien.Size = new Size(245, 28);
            cmbxGiangVien.TabIndex = 22;
            // 
            // cmbxMonHoc
            // 
            cmbxMonHoc.FormattingEnabled = true;
            cmbxMonHoc.Location = new Point(104, 188);
            cmbxMonHoc.Name = "cmbxMonHoc";
            cmbxMonHoc.Size = new Size(247, 28);
            cmbxMonHoc.TabIndex = 23;
            // 
            // cmbxLopHoc
            // 
            cmbxLopHoc.FormattingEnabled = true;
            cmbxLopHoc.Location = new Point(106, 108);
            cmbxLopHoc.Name = "cmbxLopHoc";
            cmbxLopHoc.Size = new Size(245, 28);
            cmbxLopHoc.TabIndex = 24;
            // 
            // FormLichHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 593);
            Controls.Add(cmbxLopHoc);
            Controls.Add(cmbxMonHoc);
            Controls.Add(cmbxGiangVien);
            Controls.Add(cmbxCaHoc);
            Controls.Add(txtSoSv);
            Controls.Add(txtNgayHoc);
            Controls.Add(txtMa);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtgLichHoc);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLichHoc";
            Text = "FormLichHoc";
            ((System.ComponentModel.ISupportInitialize)dtgLichHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private DataGridView dtgLichHoc;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMa;
        private TextBox txtNgayHoc;
        private TextBox txtSoSv;
        private ComboBox cmbxCaHoc;
        private ComboBox cmbxGiangVien;
        private ComboBox cmbxMonHoc;
        private ComboBox cmbxLopHoc;
    }
}