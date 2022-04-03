
namespace QuanLySanPham
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.label9 = new System.Windows.Forms.Label();
            this.grThongTinSanPham = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.dgvDanhSachNhaCungCap = new System.Windows.Forms.DataGridView();
            this.dgvcMaNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcTenNcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grThongTinSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(284, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // grThongTinSanPham
            // 
            this.grThongTinSanPham.Controls.Add(this.txtMail);
            this.grThongTinSanPham.Controls.Add(this.txtDiaChi);
            this.grThongTinSanPham.Controls.Add(this.btnDong);
            this.grThongTinSanPham.Controls.Add(this.btnLamMoi);
            this.grThongTinSanPham.Controls.Add(this.btnCapNhat);
            this.grThongTinSanPham.Controls.Add(this.btnXoa);
            this.grThongTinSanPham.Controls.Add(this.btnThem);
            this.grThongTinSanPham.Controls.Add(this.label7);
            this.grThongTinSanPham.Controls.Add(this.label6);
            this.grThongTinSanPham.Controls.Add(this.label5);
            this.grThongTinSanPham.Controls.Add(this.txtSoDienThoai);
            this.grThongTinSanPham.Controls.Add(this.txtTenNhaCungCap);
            this.grThongTinSanPham.Controls.Add(this.label1);
            this.grThongTinSanPham.Controls.Add(this.txtMaNhaCungCap);
            this.grThongTinSanPham.Controls.Add(this.lblMaSanPham);
            this.grThongTinSanPham.Location = new System.Drawing.Point(12, 52);
            this.grThongTinSanPham.Name = "grThongTinSanPham";
            this.grThongTinSanPham.Size = new System.Drawing.Size(803, 201);
            this.grThongTinSanPham.TabIndex = 25;
            this.grThongTinSanPham.TabStop = false;
            this.grThongTinSanPham.Text = "Thông Tin Sản Phẩm";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(398, 94);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 20);
            this.txtMail.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 147);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(440, 20);
            this.txtDiaChi.TabIndex = 5;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(626, 88);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 35);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(680, 139);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(87, 35);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(567, 139);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(89, 35);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(680, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 35);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(567, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 35);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(110, 92);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(136, 20);
            this.txtSoDienThoai.TabIndex = 3;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(398, 49);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(152, 20);
            this.txtTenNhaCungCap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Nhà Cung Cấp:";
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(110, 49);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(136, 20);
            this.txtMaNhaCungCap.TabIndex = 1;
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Location = new System.Drawing.Point(6, 50);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(98, 13);
            this.lblMaSanPham.TabIndex = 0;
            this.lblMaSanPham.Text = "Mã Nhà Cung Cấp:";
            // 
            // dgvDanhSachNhaCungCap
            // 
            this.dgvDanhSachNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcMaNcc,
            this.dgvcTenNcc,
            this.dgvcDChi,
            this.dgvcSDT,
            this.dgvcMail});
            this.dgvDanhSachNhaCungCap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachNhaCungCap.Location = new System.Drawing.Point(0, 269);
            this.dgvDanhSachNhaCungCap.Name = "dgvDanhSachNhaCungCap";
            this.dgvDanhSachNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachNhaCungCap.Size = new System.Drawing.Size(829, 188);
            this.dgvDanhSachNhaCungCap.TabIndex = 27;
            this.dgvDanhSachNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNhaCungCap_CellClick);
            // 
            // dgvcMaNcc
            // 
            this.dgvcMaNcc.DataPropertyName = "MaNcc";
            this.dgvcMaNcc.HeaderText = "Mã Nhà Cung Cấp";
            this.dgvcMaNcc.Name = "dgvcMaNcc";
            // 
            // dgvcTenNcc
            // 
            this.dgvcTenNcc.DataPropertyName = "TenNcc";
            this.dgvcTenNcc.HeaderText = "Tên Nhà Cung Cấp";
            this.dgvcTenNcc.Name = "dgvcTenNcc";
            // 
            // dgvcDChi
            // 
            this.dgvcDChi.DataPropertyName = "DChi";
            this.dgvcDChi.HeaderText = "Địa Chỉ";
            this.dgvcDChi.Name = "dgvcDChi";
            // 
            // dgvcSDT
            // 
            this.dgvcSDT.DataPropertyName = "SDT";
            this.dgvcSDT.HeaderText = "Số Điện Thoại";
            this.dgvcSDT.Name = "dgvcSDT";
            // 
            // dgvcMail
            // 
            this.dgvcMail.DataPropertyName = "MAIL";
            this.dgvcMail.HeaderText = "Mail";
            this.dgvcMail.Name = "dgvcMail";
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 457);
            this.Controls.Add(this.dgvDanhSachNhaCungCap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grThongTinSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhaCungCap";
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.grThongTinSanPham.ResumeLayout(false);
            this.grThongTinSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grThongTinSanPham;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.DataGridView dgvDanhSachNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMaNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcTenNcc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcMail;
    }
}