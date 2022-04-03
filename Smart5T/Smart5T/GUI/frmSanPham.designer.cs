
namespace QuanLySanPham
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.grThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboMaNhaCungCap = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nurSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dtpNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.dgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.dgvcMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcAnhMinhHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMaNhaCungCap = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvcNgaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcHanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnMo = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTinSanPham
            // 
            this.grThongTinSanPham.Controls.Add(this.txtDonGia);
            this.grThongTinSanPham.Controls.Add(this.cboMaNhaCungCap);
            this.grThongTinSanPham.Controls.Add(this.btnDong);
            this.grThongTinSanPham.Controls.Add(this.btnLamMoi);
            this.grThongTinSanPham.Controls.Add(this.btnCapNhat);
            this.grThongTinSanPham.Controls.Add(this.btnXoa);
            this.grThongTinSanPham.Controls.Add(this.btnThem);
            this.grThongTinSanPham.Controls.Add(this.dtpHanSuDung);
            this.grThongTinSanPham.Controls.Add(this.label7);
            this.grThongTinSanPham.Controls.Add(this.label6);
            this.grThongTinSanPham.Controls.Add(this.label5);
            this.grThongTinSanPham.Controls.Add(this.nurSoLuong);
            this.grThongTinSanPham.Controls.Add(this.dtpNgaySanXuat);
            this.grThongTinSanPham.Controls.Add(this.cboDonViTinh);
            this.grThongTinSanPham.Controls.Add(this.txtTenSanPham);
            this.grThongTinSanPham.Controls.Add(this.label4);
            this.grThongTinSanPham.Controls.Add(this.label3);
            this.grThongTinSanPham.Controls.Add(this.label2);
            this.grThongTinSanPham.Controls.Add(this.label1);
            this.grThongTinSanPham.Controls.Add(this.txtMaSanPham);
            this.grThongTinSanPham.Controls.Add(this.lblMaSanPham);
            this.grThongTinSanPham.Location = new System.Drawing.Point(12, 35);
            this.grThongTinSanPham.Name = "grThongTinSanPham";
            this.grThongTinSanPham.Size = new System.Drawing.Size(772, 255);
            this.grThongTinSanPham.TabIndex = 0;
            this.grThongTinSanPham.TabStop = false;
            this.grThongTinSanPham.Text = "Thông Tin Sản Phẩm";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(394, 104);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(124, 21);
            this.txtDonGia.TabIndex = 22;
            this.txtDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // cboMaNhaCungCap
            // 
            this.cboMaNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNhaCungCap.FormattingEnabled = true;
            this.cboMaNhaCungCap.Items.AddRange(new object[] {
            "ml",
            "l",
            "g"});
            this.cboMaNhaCungCap.Location = new System.Drawing.Point(394, 157);
            this.cboMaNhaCungCap.Name = "cboMaNhaCungCap";
            this.cboMaNhaCungCap.Size = new System.Drawing.Size(124, 21);
            this.cboMaNhaCungCap.TabIndex = 21;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(602, 127);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 35);
            this.btnDong.TabIndex = 20;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(656, 178);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(87, 35);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(543, 178);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(89, 35);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(656, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 35);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(543, 73);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 35);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpHanSuDung
            // 
            this.dtpHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanSuDung.Location = new System.Drawing.Point(393, 208);
            this.dtpHanSuDung.Name = "dtpHanSuDung";
            this.dtpHanSuDung.Size = new System.Drawing.Size(124, 21);
            this.dtpHanSuDung.TabIndex = 15;
            this.dtpHanSuDung.ValueChanged += new System.EventHandler(this.dtpHanSuDung_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hạn Sử Dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã Nhà Cung Cấp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đơn Giá:";
            // 
            // nurSoLuong
            // 
            this.nurSoLuong.Location = new System.Drawing.Point(394, 53);
            this.nurSoLuong.Name = "nurSoLuong";
            this.nurSoLuong.Size = new System.Drawing.Size(123, 21);
            this.nurSoLuong.TabIndex = 9;
            this.nurSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpNgaySanXuat
            // 
            this.dtpNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySanXuat.Location = new System.Drawing.Point(99, 207);
            this.dtpNgaySanXuat.Name = "dtpNgaySanXuat";
            this.dtpNgaySanXuat.Size = new System.Drawing.Size(124, 21);
            this.dtpNgaySanXuat.TabIndex = 8;
            this.dtpNgaySanXuat.ValueChanged += new System.EventHandler(this.dtpNgaySanXuat_ValueChanged);
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Items.AddRange(new object[] {
            "ml",
            "l",
            "g"});
            this.cboDonViTinh.Location = new System.Drawing.Point(99, 157);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(124, 21);
            this.cboDonViTinh.TabIndex = 7;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(99, 106);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(124, 21);
            this.txtTenSanPham.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Sản Xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn Vị Tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Sản Phẩm:";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Location = new System.Drawing.Point(99, 49);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(124, 21);
            this.txtMaSanPham.TabIndex = 1;
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Location = new System.Drawing.Point(6, 50);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(75, 13);
            this.lblMaSanPham.TabIndex = 0;
            this.lblMaSanPham.Text = "Mã Sản Phẩm:";
            // 
            // dgvDanhSachSanPham
            // 
            this.dgvDanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcMaSanPham,
            this.dgvcTenSanPham,
            this.dgvcAnhMinhHoa,
            this.dgvcDonViTinh,
            this.dgvcSoLuong,
            this.dgvcDonGia,
            this.dgvcMaNhaCungCap,
            this.dgvcNgaySanXuat,
            this.dgvcHanSuDung});
            this.dgvDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(0, 309);
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(1392, 255);
            this.dgvDanhSachSanPham.TabIndex = 1;
            this.dgvDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanPham_CellClick);
            this.dgvDanhSachSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanPham_CellContentClick);
            // 
            // dgvcMaSanPham
            // 
            this.dgvcMaSanPham.DataPropertyName = "Masp";
            this.dgvcMaSanPham.HeaderText = "Mã Sản Phẩm";
            this.dgvcMaSanPham.Name = "dgvcMaSanPham";
            // 
            // dgvcTenSanPham
            // 
            this.dgvcTenSanPham.DataPropertyName = "Tensp";
            this.dgvcTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.dgvcTenSanPham.Name = "dgvcTenSanPham";
            // 
            // dgvcAnhMinhHoa
            // 
            this.dgvcAnhMinhHoa.DataPropertyName = "AnhMinhHoa";
            this.dgvcAnhMinhHoa.HeaderText = "Ảnh";
            this.dgvcAnhMinhHoa.Name = "dgvcAnhMinhHoa";
            // 
            // dgvcDonViTinh
            // 
            this.dgvcDonViTinh.DataPropertyName = "DonViTinh";
            this.dgvcDonViTinh.HeaderText = "Đơn Vị Tính";
            this.dgvcDonViTinh.Name = "dgvcDonViTinh";
            // 
            // dgvcSoLuong
            // 
            this.dgvcSoLuong.DataPropertyName = "SoLuong";
            this.dgvcSoLuong.HeaderText = "Số Lượng";
            this.dgvcSoLuong.Name = "dgvcSoLuong";
            // 
            // dgvcDonGia
            // 
            this.dgvcDonGia.DataPropertyName = "DonGia";
            this.dgvcDonGia.HeaderText = "Đơn Giá";
            this.dgvcDonGia.Name = "dgvcDonGia";
            // 
            // dgvcMaNhaCungCap
            // 
            this.dgvcMaNhaCungCap.DataPropertyName = "MaNhaCungCap";
            this.dgvcMaNhaCungCap.HeaderText = "Mã Nhà Cung Cấp";
            this.dgvcMaNhaCungCap.Name = "dgvcMaNhaCungCap";
            this.dgvcMaNhaCungCap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcMaNhaCungCap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvcNgaySanXuat
            // 
            this.dgvcNgaySanXuat.DataPropertyName = "NgaySanXuat";
            this.dgvcNgaySanXuat.HeaderText = "Ngày Sản Xuất";
            this.dgvcNgaySanXuat.Name = "dgvcNgaySanXuat";
            // 
            // dgvcHanSuDung
            // 
            this.dgvcHanSuDung.DataPropertyName = "HanSuDung";
            this.dgvcHanSuDung.HeaderText = "Hạn Sử Dụng";
            this.dgvcHanSuDung.Name = "dgvcHanSuDung";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(827, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ảnh:";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(863, 86);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.ReadOnly = true;
            this.txtAnh.Size = new System.Drawing.Size(156, 97);
            this.txtAnh.TabIndex = 21;
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(1037, 91);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(75, 23);
            this.btnMo.TabIndex = 22;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(1160, 67);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(190, 223);
            this.picAnh.TabIndex = 23;
            this.picAnh.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(580, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 564);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDanhSachSanPham);
            this.Controls.Add(this.grThongTinSanPham);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmSanPham.IconOptions.Icon")));
            this.Name = "frmSanPham";
            this.Text = "Quản Lý Sản Phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSanPham_FormClosed);
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.grThongTinSanPham.ResumeLayout(false);
            this.grThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTinSanPham;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySanXuat;
        private System.Windows.Forms.NumericUpDown nurSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHanSuDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dgvDanhSachSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.ComboBox cboMaNhaCungCap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcAnhMinhHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDonGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcMaNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNgaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcHanSuDung;
        private System.Windows.Forms.TextBox txtDonGia;
    }
}

