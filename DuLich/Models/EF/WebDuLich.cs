namespace DuLich.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebDuLich : DbContext
    {
        public WebDuLich()
            : base("name=WebDuLich")
        {
        }

        public virtual DbSet<BanTin> BanTins { get; set; }
        public virtual DbSet<BinhLuan> BinhLuans { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DanhMucDad> DanhMucDads { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhanHoiBinhLuan> PhanHoiBinhLuans { get; set; }
        public virtual DbSet<TableUser> TableUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BanTin>()
                .Property(e => e.NoiDung)
                .IsUnicode(false);

            modelBuilder.Entity<BanTin>()
                .Property(e => e.Anh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BanTin>()
                .Property(e => e.Username)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.Pass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TableUser>()
                .Property(e => e.Username)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TableUser>()
                .Property(e => e.Pass)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TableUser>()
                .Property(e => e.Quyen)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
