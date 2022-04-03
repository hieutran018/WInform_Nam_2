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

namespace GUI
{
    public partial class frmThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private NhanVienBUS _nhanVienBUS = new NhanVienBUS();
        private TaiKhoanBUS _taiKhoanNhanVienBUS = new TaiKhoanBUS();

        public frmThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            


        }

        private void frmThongTinNhanVien_Load(object sender, EventArgs e)
        {
            
        }
    }
}