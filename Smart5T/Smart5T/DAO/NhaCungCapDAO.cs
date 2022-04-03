using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        CHTL_Smart5TEntities _Smart5TEntities = new CHTL_Smart5TEntities();
        public List<NhaCungCapDTO> LayDSNhaCungCap()
        {
            List<NhaCungCapDTO> lstNhaCungCap = new List<NhaCungCapDTO>();
            lstNhaCungCap = _Smart5TEntities.tblNhaCungCaps.Where(u => u.TrangThai == 1).Select(v => new NhaCungCapDTO { MaNcc = v.MaNcc, TenNcc = v.TenNcc, DChi = v.DChi, SDT = v.SDT, MAIL = v.MAIL }).ToList();
            return lstNhaCungCap;
        }
         
        public bool ThemNCC(NhaCungCapDTO nhacungcap)
        {
            tblNhaCungCap NhaCungCap = new tblNhaCungCap();
            NhaCungCap.MaNcc = nhacungcap.MaNcc;
            NhaCungCap.TenNcc = nhacungcap.TenNcc;
            NhaCungCap.DChi = nhacungcap.DChi;
            NhaCungCap.SDT = nhacungcap.SDT;
            NhaCungCap.MAIL = nhacungcap.MAIL;
            NhaCungCap.TrangThai = 1;

            tblNhaCungCap NhaCungCapEF = _Smart5TEntities.tblNhaCungCaps.Add(NhaCungCap);
            _Smart5TEntities.SaveChanges();

            return NhaCungCapEF.MaNcc != null;
        }

        public bool XoaNCC(NhaCungCapDTO nhacungcap)
        {
            try 
            {
                tblNhaCungCap NhaCungCap = _Smart5TEntities.tblNhaCungCaps.SingleOrDefault(u => u.MaNcc == nhacungcap.MaNcc && u.TrangThai == 1);
                NhaCungCap.TrangThai = 0;

                _Smart5TEntities.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }                     
        }

        public bool CapNhatNCC(NhaCungCapDTO nhacungcap)
        {
            try
            {
                tblNhaCungCap NhaCungCap = _Smart5TEntities.tblNhaCungCaps.SingleOrDefault(u => u.MaNcc == nhacungcap.MaNcc && u.TrangThai == 1);
                NhaCungCap.MaNcc = nhacungcap.MaNcc;
                NhaCungCap.TenNcc = nhacungcap.TenNcc;
                NhaCungCap.DChi = nhacungcap.DChi;
                NhaCungCap.SDT = nhacungcap.SDT;
                NhaCungCap.MAIL = nhacungcap.MAIL;
                NhaCungCap.TrangThai = 1;

                _Smart5TEntities.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
