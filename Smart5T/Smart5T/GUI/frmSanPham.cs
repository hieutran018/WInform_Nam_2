using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using GUI;

namespace QuanLySanPham
{
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {               
        private SanPhamBUS _SanPhamBUS = new SanPhamBUS();
        private NhaCungCapBUS _NhaCungCapBUS = new NhaCungCapBUS();
        public frmSanPham()
        {
            InitializeComponent();
            

            //Đổ dữ liệu vào combobox
            cboMaNhaCungCap.DataSource = _NhaCungCapBUS.LayDSNhaCungCap();
            cboMaNhaCungCap.DisplayMember = "MaNcc";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            //Đổ dữ liệu vào datagridview 
            dgvcMaNhaCungCap.DataSource = _NhaCungCapBUS.LayDSNhaCungCap();
            dgvcMaNhaCungCap.DisplayMember = "MaNcc";

            cboDonViTinh.SelectedItem = "ml";
            

            dgvDanhSachSanPham.DataSource = _SanPhamBUS.LayDSSanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSanPham.Text) || string.IsNullOrEmpty(txtTenSanPham.Text) || string.IsNullOrEmpty(txtAnh.Text) || string.IsNullOrEmpty(cboDonViTinh.Text) || string.IsNullOrEmpty(nurSoLuong.Text) || string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(cboMaNhaCungCap.Text) || dtpNgaySanXuat.Value > DateTime.Now )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.Masp = txtMaSanPham.Text;
                sp.Tensp = txtTenSanPham.Text;
                sp.AnhMinhHoa = txtAnh.Text;
                sp.DonViTinh = cboDonViTinh.Text;
                sp.SoLuong = Convert.ToInt32(nurSoLuong.Value);
                sp.DonGia = Convert.ToDecimal(txtDonGia.Text);
                sp.MaNhaCungCap = cboMaNhaCungCap.Text;
                sp.NgaySanXuat = Convert.ToDateTime(dtpNgaySanXuat.Text);               
                sp.HanSuDung = Convert.ToDateTime(dtpHanSuDung.Text);
                

                if (_SanPhamBUS.ThemSP(sp))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSanPham_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("Hãy nhập mã sản phẩm khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDanhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSanPham.Text = dgvDanhSachSanPham.SelectedCells[0].Value.ToString();
            txtTenSanPham.Text = dgvDanhSachSanPham.SelectedCells[1].Value.ToString();
            txtAnh.Text = dgvDanhSachSanPham.SelectedCells[2].Value.ToString();
            cboDonViTinh.Text = dgvDanhSachSanPham.SelectedCells[3].Value.ToString();
            nurSoLuong.Text = dgvDanhSachSanPham.SelectedCells[4].Value.ToString();
            txtDonGia.Text = dgvDanhSachSanPham.SelectedCells[5].Value.ToString();
            cboMaNhaCungCap.SelectedItem = dgvDanhSachSanPham.SelectedCells[6].Value.ToString();
            dtpNgaySanXuat.Value = Convert.ToDateTime(dgvDanhSachSanPham.SelectedCells[7].Value.ToString());
            dtpHanSuDung.Value = Convert.ToDateTime(dgvDanhSachSanPham.SelectedCells[8].Value.ToString());

            picAnh.Image = Image.FromFile(txtAnh.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSanPham.Text) || string.IsNullOrEmpty(txtTenSanPham.Text) || string.IsNullOrEmpty(txtAnh.Text) || string.IsNullOrEmpty(cboDonViTinh.Text) || string.IsNullOrEmpty(nurSoLuong.Text) || string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(cboMaNhaCungCap.Text) || dtpNgaySanXuat.Value > DateTime.Now)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.Masp = txtMaSanPham.Text;
                sp.Tensp = txtTenSanPham.Text;
                sp.AnhMinhHoa = txtAnh.Text;
                sp.DonViTinh = cboDonViTinh.Text;
                sp.SoLuong = Convert.ToInt32(nurSoLuong.Value);
                sp.DonGia = Convert.ToDecimal(txtDonGia.Text);
                sp.MaNhaCungCap = cboMaNhaCungCap.Text;
                sp.NgaySanXuat = Convert.ToDateTime(dtpNgaySanXuat.Text);
                sp.HanSuDung = Convert.ToDateTime(dtpHanSuDung.Text);


                if (_SanPhamBUS.XoaSP(sp))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSanPham_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSanPham.Text) || string.IsNullOrEmpty(txtTenSanPham.Text) || string.IsNullOrEmpty(txtAnh.Text) || string.IsNullOrEmpty(cboDonViTinh.Text) || string.IsNullOrEmpty(nurSoLuong.Text) || string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(cboMaNhaCungCap.Text) || dtpNgaySanXuat.Value > DateTime.Now)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.Masp = txtMaSanPham.Text;
                sp.Tensp = txtTenSanPham.Text;
                sp.AnhMinhHoa = txtAnh.Text;
                sp.DonViTinh = cboDonViTinh.Text;
                sp.SoLuong = Convert.ToInt32(nurSoLuong.Value);
                sp.DonGia = Convert.ToDecimal(txtDonGia.Text);
                sp.MaNhaCungCap = cboMaNhaCungCap.Text;
                sp.NgaySanXuat = Convert.ToDateTime(dtpNgaySanXuat.Text);
                sp.HanSuDung = Convert.ToDateTime(dtpHanSuDung.Text);


                if (_SanPhamBUS.CapNhatSP(sp))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmSanPham_Load(sender, e);
                }

                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSanPham.Text = string.Empty;
            txtTenSanPham.Text = string.Empty;
            cboDonViTinh.Text = string.Empty;
            nurSoLuong.Value = 0;
            txtDonGia.Text = string.Empty;
            cboMaNhaCungCap.SelectedIndex = 0;
            dtpNgaySanXuat.Value = DateTime.Now;
            dtpHanSuDung.Value = DateTime.Now;
            txtMaSanPham.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Char.IsDigit(e.KeyChar) --> kiểm tra xem phím vừa nhập vào textbox có phải là ký tự số hay không, hàm này trả về kiểu bool
            //Char.IsContro(e.KeyChar)-- > kiểm tra xem phím vừa nhập vào textbox có phải là các ký tự điều khiển(các phím mũi tên, Delete, Insert, backspace, space bar)
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal themPhay = Convert.ToDecimal(txtDonGia.Text.Replace(",", ""));
                txtDonGia.Text = themPhay.ToString("0,0");
                txtDonGia.Select(txtDonGia.TextLength, 0);
            }
            catch (Exception)
            {
            }
        }

        private void btnMo_Click(object sender, EventArgs e)
        {            
            OpenFileDialog ofdImages = new OpenFileDialog();
            ofdImages.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(ofdImages.FileName);
                txtAnh.Text = ofdImages.FileName;
            }
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void dtpNgaySanXuat_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaySanXuat.Value > dtpHanSuDung.Value)
            {
                MessageBox.Show("Vui lòng nhập lại Ngày Sản Xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtpHanSuDung_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgaySanXuat.Value > dtpHanSuDung.Value)
            {
                MessageBox.Show("Vui lòng nhập lại Hạn Sử Dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
