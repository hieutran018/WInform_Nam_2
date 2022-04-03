using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        CHTL_Smart5TEntities _Smart5TEntities = new CHTL_Smart5TEntities();


        public List<NhanVienDTO> LayDanhSachNhanVien()
        {
            return _Smart5TEntities.tblNhanViens.Where(v => v.TrangThai == 1).Select(u => new NhanVienDTO { MaNV = u.MaNV, HoNV = u.HoNV, TenNV = u.TenNV, GioiTinh = u.GioiTinh, NgSinh = u.NgSinh.Value, Dchi = u.Dchi, SDT = u.SDT, Luong = u.Luong.Value }).ToList();
        }
        public NhanVienDTO LayThongTinNhanVien (string MaNhanVien)
        {
            tblNhanVien nhanVienDTO = _Smart5TEntities.tblNhanViens.SingleOrDefault(u => u.MaNV == MaNhanVien);

            if (nhanVienDTO == null) return null;

            NhanVienDTO nhanVien = new NhanVienDTO()
            {
                MaNV = nhanVienDTO.MaNV,
                HoNV = nhanVienDTO.HoNV,
                TenNV = nhanVienDTO.TenNV,
                GioiTinh = nhanVienDTO.GioiTinh,
                Dchi = nhanVienDTO.Dchi,
                NgSinh = nhanVienDTO.NgSinh.GetValueOrDefault(),
                SDT = nhanVienDTO.SDT,
                Luong = nhanVienDTO.Luong.GetValueOrDefault()

            };
            return nhanVien;
        }

        public bool ThemNV(NhanVienDTO nhanvien)
        {
            tblNhanVien nhanVien = new tblNhanVien();
            nhanVien.MaNV = nhanvien.MaNV;
            nhanVien.HoNV = nhanvien.HoNV;
            nhanVien.TenNV = nhanvien.TenNV;
            nhanVien.GioiTinh = nhanvien.GioiTinh;
            nhanVien.NgSinh = nhanvien.NgSinh;
            nhanVien.Dchi = nhanvien.Dchi;
            nhanVien.SDT = nhanvien.SDT;
            nhanVien.Luong = nhanvien.Luong;
            nhanVien.TrangThai = 1;

            tblNhanVien nhanVienEF = _Smart5TEntities.tblNhanViens.Add(nhanVien);
            _Smart5TEntities.SaveChanges();

            return nhanVienEF.MaNV != null; 
        }

        public bool XoaNhanVien(NhanVienDTO nhanvien)
        {
            try
            {
                tblNhanVien nhanVien = _Smart5TEntities.tblNhanViens.SingleOrDefault(u => u.MaNV == nhanvien.MaNV && u.TrangThai == 1);
                nhanVien.TrangThai = 0;
                return true;
            }
            catch(Exception exc)
            {
                return false;
            }
        }

        public bool SuaThongTinNhanVien(NhanVienDTO nhanvien)
        {
            try
            {
                tblNhanVien nhanVien = _Smart5TEntities.tblNhanViens.SingleOrDefault(u => u.MaNV == nhanvien.MaNV && u.TrangThai == 1);

                nhanVien.HoNV = nhanvien.HoNV;
                nhanVien.TenNV = nhanvien.TenNV;
                nhanvien.NgSinh = nhanvien.NgSinh;
                nhanVien.GioiTinh = nhanvien.GioiTinh;
                nhanVien.Dchi = nhanvien.Dchi;
                nhanVien.SDT = nhanvien.SDT;
                nhanVien.Luong = nhanvien.Luong;
                nhanVien.TrangThai = 1;

                _Smart5TEntities.SaveChanges();

                return true;

            }
            catch(Exception exc)
            {
                return false;
            }
        }

    }
}
