using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class SanPhamDAO
    {
        CHTL_Smart5TEntities _Smart5TEntities = new CHTL_Smart5TEntities();
        public List<SanPhamDTO> LayDSSanPham()
        {           
            return _Smart5TEntities.tblSanPhams.Where(v => v.TrangThai == 1).Select(u => new SanPhamDTO { Masp = u.MaSp, Tensp = u.TenSp, AnhMinhHoa = u.AnhMinhHoa, DonViTinh = u.DonViTinh, SoLuong = u.SoLuong, DonGia = u.DonGia, MaNhaCungCap = u.MaNhaCungCap, NgaySanXuat = u.NgaySanXuat, HanSuDung = u.HanSuDung }).ToList();
        }

        public bool ThemSP(SanPhamDTO sp)
        {

            tblSanPham sanpham = new tblSanPham();
            sanpham.MaSp = sp.Masp;
            sanpham.TenSp = sp.Tensp;
            sanpham.AnhMinhHoa = sp.AnhMinhHoa;
            sanpham.DonViTinh = sp.DonViTinh;
            sanpham.SoLuong = sp.SoLuong;
            sanpham.DonGia = sp.DonGia;
            sanpham.MaNhaCungCap = sp.MaNhaCungCap;
            sanpham.NgaySanXuat = sp.NgaySanXuat;
            sanpham.HanSuDung = sp.HanSuDung;
            sanpham.TrangThai = 1;
            
            tblSanPham sanphamEF = _Smart5TEntities.tblSanPhams.Add(sanpham);
            _Smart5TEntities.SaveChanges();
            return sanphamEF.MaSp != null;

            //try
            //{
            //    int tam = _qlSanPhamEntities.THEMSANPHAM(1, sp.Masp, sp.Tensp, sp.AnhMinhHoa, sp.DonViTinh, sp.SoLuong, sp.DonGia, sp.MaNhaCungCap, sp.NgaySanXuat, sp.HanSuDung);

            //    _qlSanPhamEntities.SaveChanges();
            //    return true;
            //}
            //catch (Exception)
            //{
            // return false ;
            //}
        }

        public bool XoaSP(SanPhamDTO sp)
        {
            try
            {
                tblSanPham SanPham = _Smart5TEntities.tblSanPhams.SingleOrDefault(u => u.MaSp == sp.Masp && u.TrangThai == 1);
                SanPham.TrangThai = 0;

                _Smart5TEntities.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }                      
        }

        public bool CapNhatSP(SanPhamDTO sp)
        {
            try
            {
                tblSanPham SanPham = _Smart5TEntities.tblSanPhams.SingleOrDefault(u => u.MaSp == sp.Masp && u.TrangThai == 1);
                SanPham.TenSp = sp.Tensp;
                SanPham.AnhMinhHoa = sp.AnhMinhHoa;
                SanPham.DonViTinh = sp.DonViTinh;
                SanPham.SoLuong = sp.SoLuong;
                SanPham.DonGia = sp.DonGia;
                SanPham.MaNhaCungCap = sp.MaNhaCungCap;
                SanPham.NgaySanXuat = sp.NgaySanXuat;
                SanPham.HanSuDung = sp.HanSuDung;
                SanPham.TrangThai = 1;

                _Smart5TEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
