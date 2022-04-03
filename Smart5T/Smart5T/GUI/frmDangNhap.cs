using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using GUI;
using BUS;

namespace CuaHangTienLoi_Smart5T
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        TaiKhoanBUS _taiKhoanBUS = new TaiKhoanBUS();        
        public frmDangNhap()
        {
           
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtTenDangNhap.Text)|| String.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_taiKhoanBUS.KtraDangNhap(txtTenDangNhap.Text, txtMatKhau.Text) != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCuaSoChinh frmCuaSoChinh = new frmCuaSoChinh();
                frmCuaSoChinh.Show();

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-45UNNJ4L\SQLEXPRESS;Initial Catalog=CHTL_Smart5T;Integrated Security=True");
            //try
            //{
            //    conn.Open();
            //    String tenTaiKhoan = txtTenDangNhap.Text;
            //    String matKhau = txtMatKhau.Text;
            //    String sql = "SELECT * FROM tblTaiKhoan WHERE TenDangNhap = '" + tenTaiKhoan + "' AND MatKhau = '" + matKhau + "'";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataReader data = cmd.ExecuteReader();

            //    if (data.Read() == true)
            //    {
            //        MessageBox.Show("Đăng nhập thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Hide();
            //        frmCuaSoChinh cuaSoChinh = new frmCuaSoChinh();
            //        cuaSoChinh.ShowDialog();
            //        this.Close();


            //    }
            //    else
            //    {
            //        MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }

            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show("Kết nối thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult resultThoat = MessageBox.Show("Đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (resultThoat)
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
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
