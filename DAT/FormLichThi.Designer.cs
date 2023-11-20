namespace DAT
{
    partial class FormLichThi
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
            label8 = new Label();
            dtgLichHoc = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtMa = new TextBox();
            txtSosv = new TextBox();
            txtNgaythi = new TextBox();
            cmbxLop = new ComboBox();
            cmbxCa = new ComboBox();
            cmbxMon = new ComboBox();
            cmbxGiangVien = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgLichHoc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 34);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Lịch Thi Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 81);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 132);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Lớp Thi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 180);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Ca Thi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 233);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Môn thi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 281);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 5;
            label6.Text = "Giảng viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 330);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 6;
            label7.Text = "Ngày Thi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 381);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 7;
            label8.Text = "Số sinh viên";
            // 
            // dtgLichHoc
            // 
            dtgLichHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLichHoc.Location = new Point(57, 433);
            dtgLichHoc.Name = "dtgLichHoc";
            dtgLichHoc.RowHeadersWidth = 51;
            dtgLichHoc.RowTemplate.Height = 29;
            dtgLichHoc.Size = new Size(658, 188);
            dtgLichHoc.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(611, 83);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 69);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(611, 180);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 69);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(611, 281);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 69);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtMa
            // 
            txtMa.Location = new Point(160, 74);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(312, 27);
            txtMa.TabIndex = 12;
            // 
            // txtSosv
            // 
            txtSosv.Location = new Point(160, 374);
            txtSosv.Name = "txtSosv";
            txtSosv.Size = new Size(312, 27);
            txtSosv.TabIndex = 13;
            // 
            // txtNgaythi
            // 
            txtNgaythi.Location = new Point(160, 323);
            txtNgaythi.Name = "txtNgaythi";
            txtNgaythi.Size = new Size(312, 27);
            txtNgaythi.TabIndex = 15;
            // 
            // cmbxLop
            // 
            cmbxLop.FormattingEnabled = true;
            cmbxLop.Location = new Point(160, 129);
            cmbxLop.Name = "cmbxLop";
            cmbxLop.Size = new Size(239, 28);
            cmbxLop.TabIndex = 17;
            // 
            // cmbxCa
            // 
            cmbxCa.FormattingEnabled = true;
            cmbxCa.Location = new Point(160, 180);
            cmbxCa.Name = "cmbxCa";
            cmbxCa.Size = new Size(239, 28);
            cmbxCa.TabIndex = 18;
            // 
            // cmbxMon
            // 
            cmbxMon.FormattingEnabled = true;
            cmbxMon.Location = new Point(160, 233);
            cmbxMon.Name = "cmbxMon";
            cmbxMon.Size = new Size(239, 28);
            cmbxMon.TabIndex = 19;
            // 
            // cmbxGiangVien
            // 
            cmbxGiangVien.FormattingEnabled = true;
            cmbxGiangVien.Location = new Point(160, 278);
            cmbxGiangVien.Name = "cmbxGiangVien";
            cmbxGiangVien.Size = new Size(239, 28);
            cmbxGiangVien.TabIndex = 20;
            // 
            // FormLichThi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 704);
            Controls.Add(cmbxGiangVien);
            Controls.Add(cmbxMon);
            Controls.Add(cmbxCa);
            Controls.Add(cmbxLop);
            Controls.Add(txtNgaythi);
            Controls.Add(txtSosv);
            Controls.Add(txtMa);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dtgLichHoc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLichThi";
            Text = "FormLichThi";
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
        private Label label8;
        private DataGridView dtgLichHoc;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtMa;
        private TextBox txtSosv;
        private TextBox txtNgaythi;
        private ComboBox cmbxCa;
        private ComboBox cmbxMon;
        private ComboBox cmbxGiangVien;
        private ComboBox cmbxLop;
    }
}