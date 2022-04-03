using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgSinh { get; set; }
        public string GioiTinh { get; set; }
        public string Dchi { get; set; }
        public string SDT { get; set; }
        public Decimal Luong { get; set; }
    }
}
