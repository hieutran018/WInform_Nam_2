using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLySanPham
{
    public partial class frmNhaCungCap : Form
    {
        private NhaCungCapBUS _NhaCungCapBUS = new NhaCungCapBUS();
        string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvDanhSachNhaCungCap.DataSource = _NhaCungCapBUS.LayDSNhaCungCap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {          
                NhaCungCapDTO nhacungcap = new NhaCungCapDTO();
                nhacungcap.MaNcc = txtMaNhaCungCap.Text;
                nhacungcap.TenNcc = txtTenNhaCungCap.Text;
                nhacungcap.DChi = txtDiaChi.Text;
                nhacungcap.SDT = txtSoDienThoai.Text;
                nhacungcap.MAIL = txtMail.Text;
            //do 
            //{ 
            //    nhacungcap.MAIL = txtMail.Text;
            //    MessageBox.Show("Vui lòng nhập lại Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             
            //} while (IsValidEmail(txtMail.Text) == false);


                if (_NhaCungCapBUS.ThemSP(nhacungcap))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmNhaCungCap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                        
        }       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nhacungcap = new NhaCungCapDTO();
            nhacungcap.MaNcc = txtMaNhaCungCap.Text;
            nhacungcap.TenNcc = txtTenNhaCungCap.Text;
            nhacungcap.DChi = txtDiaChi.Text;
            nhacungcap.SDT = txtSoDienThoai.Text;
            nhacungcap.MAIL = txtMail.Text;

            if (_NhaCungCapBUS.XoaNCC(nhacungcap))
            {
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNhaCungCap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xoá thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nhacungcap = new NhaCungCapDTO();
            nhacungcap.MaNcc = txtMaNhaCungCap.Text;
            nhacungcap.TenNcc = txtTenNhaCungCap.Text;
            nhacungcap.DChi = txtDiaChi.Text;
            nhacungcap.SDT = txtSoDienThoai.Text;
            nhacungcap.MAIL = txtMail.Text;

            if (_NhaCungCapBUS.CapNhatNCC(nhacungcap))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmNhaCungCap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhSachNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhaCungCap.Enabled = false;
            txtMaNhaCungCap.Text = dgvDanhSachNhaCungCap.SelectedCells[0].Value.ToString();
            txtTenNhaCungCap.Text = dgvDanhSachNhaCungCap.SelectedCells[1].Value.ToString();
            txtSoDienThoai.Text = dgvDanhSachNhaCungCap.SelectedCells[2].Value.ToString();
            txtMail.Text = dgvDanhSachNhaCungCap.SelectedCells[3].Value.ToString();
            txtDiaChi.Text = dgvDanhSachNhaCungCap.SelectedCells[4].Value.ToString();          
        }     

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhaCungCap.Text = string.Empty;
            txtTenNhaCungCap.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

   //     public bool IsValidEmail(string email)
   //     {
   //         try
   //         {
   //             int nFirt = int.Parse(email.Substring(0, 1));
   //             return false;
   //         }
   //         catch
   //         {
   //             string pattern = @"^[_a-zA-Z0-9][_.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[_.a-zA-Z0-9]+)*\.
   //(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|vn|[a-zA-Z]{2})$";
   //             //Regular expression object
   //             Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
   //             //boolean variable to return to calling method
   //             bool valid = false;

   //             //make sure an email address was provided
   //             if (string.IsNullOrEmpty(email))
   //             {
   //                 valid = false;
   //             }
   //             else
   //             {
   //                 //use IsMatch to validate the address
   //                 valid = check.IsMatch(email.ToLower());
   //             }
   //             //return the value to the calling method
   //             return valid;
   //         }
   //     }
    }
}
