using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAO _NhaCungCapDAO = new DAO.NhaCungCapDAO();
        public List<NhaCungCapDTO> LayDSNhaCungCap()
        {
            return _NhaCungCapDAO.LayDSNhaCungCap();
        }

        public bool ThemSP(NhaCungCapDTO ncc)
        {
            return _NhaCungCapDAO.ThemNCC(ncc);
        }

        public bool XoaNCC(NhaCungCapDTO ncc)
        {
            return _NhaCungCapDAO.XoaNCC(ncc);
        }

        public bool CapNhatNCC(NhaCungCapDTO ncc)
        {
            return _NhaCungCapDAO.CapNhatNCC(ncc);
        }
    }
}
