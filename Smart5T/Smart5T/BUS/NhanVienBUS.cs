using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO _nhanVienDAO = new NhanVienDAO();

        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return _nhanVienDAO.LayDanhSachNhanVien();
        }

        public NhanVienDTO LayChiTietNhanVien(string maNhanVien)
        {
            return _nhanVienDAO.LayThongTinNhanVien(maNhanVien);
        }

        public bool ThemNV(NhanVienDTO nhanvien)
        {
            return _nhanVienDAO.ThemNV(nhanvien);
        }

        public bool XoaNhanVien(NhanVienDTO nhanvien)
        {
            return _nhanVienDAO.XoaNhanVien(nhanvien);
        }
        
        public bool SuaThongTinNhanVien(NhanVienDTO nhanvien)
        {
            return _nhanVienDAO.SuaThongTinNhanVien(nhanvien);
        }
    }
}
