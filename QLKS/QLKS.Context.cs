﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLKSEntities : DbContext
    {
        public QLKSEntities()
            : base("name=QLKSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietPhieuThue> ChiTietPhieuThue { get; set; }
        public virtual DbSet<DichVu> DichVu { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LoaiDichVu> LoaiDichVu { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhong { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Phieuthuephong> Phieuthuephong { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }
        public virtual DbSet<SuDungDichVu> SuDungDichVu { get; set; }
    }
}