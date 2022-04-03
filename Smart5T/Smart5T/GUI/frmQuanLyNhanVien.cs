using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Globalization;

namespace GUI
{
    public partial class frmQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        NhanVienBUS _NhanVienBUS = new NhanVienBUS();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvDanhSachNhanVien.DataSource = _NhanVienBUS.LayDanhSachNhanVien();
        }

        public int Get_Year(DateTime strNgSinh)
        {
            string str = strNgSinh.ToString().Trim();
            str = str.Substring(6, 4);
            int Nam = Convert.ToInt32(str);
            return Nam;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtMaNhanVien_Nhap.Text)|| String.IsNullOrEmpty(txtHoNhanVien_Nhap.Text)||String.IsNullOrEmpty(txtTenNhanVien__Nhap.Text)
                ||String.IsNullOrEmpty(txtDiaChiNhanVien_Nhap.Text)||String.IsNullOrEmpty(txtSDTNhanVien_Nhap.Text)||String.IsNullOrEmpty(txtLuongNhanVien__Nhap.Text)|| ((Get_Year(DateTime.Now) - Get_Year(dtpNgSinh_Nhap.Value)) >= 18 ))
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NhanVienDTO nhanVien = new NhanVienDTO();
                nhanVien.MaNV = txtMaNhanVien_Nhap.Text;
                nhanVien.HoNV = txtHoNhanVien_Nhap.Text;
                nhanVien.TenNV = txtTenNhanVien__Nhap.Text;
                nhanVien.GioiTinh = (radNam__Nhap.Checked == true ? "Nam" : "Nữ");
                nhanVien.NgSinh = Convert.ToDateTime(dtpNgSinh_Nhap.Text);
                nhanVien.SDT = txtSDTNhanVien_Nhap.Text;
                nhanVien.Luong = Convert.ToDecimal(txtLuongNhanVien__Nhap.Text);

                if(_NhanVienBUS.ThemNV(nhanVien))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQuanLyNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Hãy kiểm tra lại thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhanVien_Nhap.Text = dgvDanhSachNhanVien.SelectedCells[1].Value.ToString();
            txtHoNhanVien_Nhap.Text = dgvDanhSachNhanVien.SelectedCells[2].Value.ToString();
            txtTenNhanVien__Nhap.Text = dgvDanhSachNhanVien.SelectedCells[3].Value.ToString();
            radNam__Nhap.Checked = (dgvDanhSachNhanVien.SelectedCells[4].Value.ToString() == "Nam" ? true : radNu_Nhap.Checked = true);
            dtpNgSinh_Nhap.Value = DateTime.ParseExact(
    dgvDanhSachNhanVien.SelectedCells[5].Value.ToString(),
    "MM-dd-yyyy",
    CultureInfo.InvariantCulture);
            txtDiaChiNhanVien_Nhap.Text = dgvDanhSachNhanVien.SelectedCells[6].Value.ToString();
            txtSDTNhanVien_Nhap.Text = dgvDanhSachNhanVien.SelectedCells[7].Value.ToString();
            txtLuongNhanVien__Nhap.Text = dgvDanhSachNhanVien.SelectedCells[9].Value.ToString();
        }
    }
}