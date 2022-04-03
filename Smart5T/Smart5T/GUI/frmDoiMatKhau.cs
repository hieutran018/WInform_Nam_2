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

namespace GUI
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_DoiMatKhau_Click(object sender, EventArgs e)
        {
            DialogResult resultDoiMatKhau_Cn = MessageBox.Show("Xác nhận đổi mật khẩu?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (resultDoiMatKhau_Cn)
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
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}