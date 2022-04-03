using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO _taiKhoanDAO = new TaiKhoanDAO();

        public TaiKhoanDTO KtraDangNhap(string tenTaiKhoan, string matKhau)
        {
            return _taiKhoanDAO.KTDangNhap(tenTaiKhoan, matKhau);
        }
    }
}
