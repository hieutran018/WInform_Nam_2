﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CHTL_Smart5TEntities : DbContext
    {
        public CHTL_Smart5TEntities()
            : base("name=CHTL_Smart5TEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblChucVu> tblChucVus { get; set; }
        public virtual DbSet<tblCT_HoaDon> tblCT_HoaDon { get; set; }
        public virtual DbSet<tblHoaDon> tblHoaDons { get; set; }
        public virtual DbSet<tblKhachHang> tblKhachHangs { get; set; }
        public virtual DbSet<tblNhaCungCap> tblNhaCungCaps { get; set; }
        public virtual DbSet<tblNhanVien> tblNhanViens { get; set; }
        public virtual DbSet<tblSanPham> tblSanPhams { get; set; }
        public virtual DbSet<tblTaiKhoan> tblTaiKhoans { get; set; }
    }
}
