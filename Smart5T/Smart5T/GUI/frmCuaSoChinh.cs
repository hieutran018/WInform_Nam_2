using CuaHangTienLoi_Smart5T;
using DevExpress.XtraBars;
using QuanLySanPham;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCuaSoChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmCuaSoChinh()
        {
            InitializeComponent();
        }


        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult resultDangXuat = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (resultDangXuat)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    this.Close();
                    frmDangNhap frmDangnhap = new frmDangNhap();
                    frmDangnhap.Show();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnChiTietNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTinNhanVien frmThongTinNhanVien = new frmThongTinNhanVien();
            frmThongTinNhanVien.ShowDialog();
        }

        private void btnDoiMatKhau_CaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau_CaNhan = new frmDoiMatKhau();
            frmDoiMatKhau_CaNhan.ShowDialog();
        }

        private void btnQuanLySanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSanPham frmSanPham = new frmSanPham();
            frmSanPham.ShowDialog();
        }

        private void btnQuanLyNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            frmNhaCungCap.ShowDialog();
        }

        private void frmCuaSoChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnQuanLyNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQuanLyNhanVien frmQuanLyNhanVien = new frmQuanLyNhanVien();
            frmQuanLyNhanVien.ShowDialog();
        }
    }
}