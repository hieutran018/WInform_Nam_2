using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAO _SanPhamDAO = new DAO.SanPhamDAO();
        public List<SanPhamDTO> LayDSSanPham()
        {
            return _SanPhamDAO.LayDSSanPham();
        }

        public bool ThemSP(SanPhamDTO sp)
        {
            return _SanPhamDAO.ThemSP(sp);
        }

        public bool XoaSP(SanPhamDTO sp)
        {
            return _SanPhamDAO.XoaSP(sp);
        }

        public bool CapNhatSP(SanPhamDTO sp)
        {
            return _SanPhamDAO.CapNhatSP(sp);
        }
    }
}
