using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        CHTL_Smart5TEntities _Smart5TEntities = new CHTL_Smart5TEntities();
        public TaiKhoanDTO KTDangNhap (string tenTaiKhoan, string matKhau)
        {
            tblTaiKhoan taiKhoanDTO = _Smart5TEntities.tblTaiKhoans.SingleOrDefault(u => u.TenDangNhap == tenTaiKhoan && u.MatKhau == matKhau);
            
            if (taiKhoanDTO == null) return null;

            TaiKhoanDTO taiKhoan = new TaiKhoanDTO()
            {
                Ma_Nvien = taiKhoanDTO.Ma_NVien,
                TenDangNhap = taiKhoanDTO.TenDangNhap,
                MatKhau = taiKhoanDTO.MatKhau,
                MaChucVu_tk = taiKhoanDTO.MaChucVu
            };
            return taiKhoan;
        }
    }
}
