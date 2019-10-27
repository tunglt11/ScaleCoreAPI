using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaleCoreAPI.Models
{
    public partial class SCALES_WITH_ALPR_DBContext : DbContext
    {
        public SCALES_WITH_ALPR_DBContext()
        {
        }

        public SCALES_WITH_ALPR_DBContext(DbContextOptions<SCALES_WITH_ALPR_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cauhinhcan> Cauhinhcan { get; set; }
        public virtual DbSet<Cauhinhcantd> Cauhinhcantd { get; set; }
        public virtual DbSet<Cauhinhin> Cauhinhin { get; set; }
        public virtual DbSet<Congty> Congty { get; set; }
        public virtual DbSet<Keys> Keys { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Loaihang> Loaihang { get; set; }
        public virtual DbSet<Loainguoidung> Loainguoidung { get; set; }
        public virtual DbSet<Nguoidung> Nguoidung { get; set; }
        public virtual DbSet<Phieucan> Phieucan { get; set; }
        public virtual DbSet<Phieucantudong> Phieucantudong { get; set; }
        public virtual DbSet<Xe> Xe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=SCALES_WITH_ALPR_DB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cauhinhcan>(entity =>
            {
                entity.ToTable("CAUHINHCAN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Com)
                    .HasColumnName("COM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Databits)
                    .HasColumnName("DATABITS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datalenght)
                    .HasColumnName("DATALENGHT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KiTuNgat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parity)
                    .HasColumnName("PARITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Raudrate)
                    .HasColumnName("RAUDRATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sfrom)
                    .HasColumnName("SFROM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sto)
                    .HasColumnName("STO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stopbit)
                    .HasColumnName("STOPBIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cauhinhcantd>(entity =>
            {
                entity.ToTable("CAUHINHCANTD");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KhoiLuong).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Cauhinhin>(entity =>
            {
                entity.ToTable("CAUHINHIN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoPhieu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenMayIn)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Congty>(entity =>
            {
                entity.ToTable("CONGTY");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(150);

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TenCongTy).HasMaxLength(100);
            });

            modelBuilder.Entity<Keys>(entity =>
            {
                entity.ToTable("KEYS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnd).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.Keys1)
                    .IsRequired()
                    .HasColumnName("Keys")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KHACHHAN__2725CF1E93E31B1E");

                entity.ToTable("KHACHHANG");

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(250);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Loaihang>(entity =>
            {
                entity.ToTable("LOAIHANG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LoaiHang1)
                    .HasColumnName("LoaiHang")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Loainguoidung>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LOAINGUO__730A5759E8A07373");

                entity.ToTable("LOAINGUOIDUNG");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TenLoaiNd)
                    .IsRequired()
                    .HasColumnName("TenLoaiND")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Nguoidung>(entity =>
            {
                entity.HasKey(e => e.MaNd)
                    .HasName("PK__NGUOIDUN__2725D724E661F6C6");

                entity.ToTable("NGUOIDUNG");

                entity.Property(e => e.MaNd)
                    .HasColumnName("MaND")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaLoai)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pin)
                    .IsRequired()
                    .HasColumnName("PIN")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TenDnhap)
                    .IsRequired()
                    .HasColumnName("TenDNhap")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TenNd)
                    .IsRequired()
                    .HasColumnName("TenND")
                    .HasMaxLength(30);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.Nguoidung)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("F_ND_LND");
            });

            modelBuilder.Entity<Phieucan>(entity =>
            {
                entity.ToTable("PHIEUCAN");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bsx)
                    .HasColumnName("BSX")
                    .HasMaxLength(50);

                entity.Property(e => e.CheDoCan).HasMaxLength(50);

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.KhachHang).HasMaxLength(250);

                entity.Property(e => e.KieuCanLan1).HasMaxLength(50);

                entity.Property(e => e.KieuCanLan2).HasMaxLength(50);

                entity.Property(e => e.KlcanLan1)
                    .HasColumnName("KLCanLan1")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.KlcanLan2)
                    .HasColumnName("KLCanLan2")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LaiXe).HasMaxLength(250);

                entity.Property(e => e.LanIn).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LoaiHang).HasMaxLength(50);

                entity.Property(e => e.MaNhanVienCanLan1)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaNhanVienCanLan2)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaPhieu).HasMaxLength(50);

                entity.Property(e => e.NgayCanLan1).HasColumnType("datetime");

                entity.Property(e => e.NgayCanLan2).HasColumnType("datetime");

                entity.Property(e => e.TenNhanVienCanLan1).HasMaxLength(250);

                entity.Property(e => e.TenNhanVienCanLan2).HasMaxLength(250);
            });

            modelBuilder.Entity<Phieucantudong>(entity =>
            {
                entity.ToTable("PHIEUCANTUDONG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Klxe)
                    .HasColumnName("KLXe")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NgayGio).HasColumnType("datetime");
            });

            modelBuilder.Entity<Xe>(entity =>
            {
                entity.HasKey(e => e.MaXe);

                entity.ToTable("XE");

                entity.Property(e => e.MaXe).HasMaxLength(50);

                entity.Property(e => e.Bsx)
                    .IsRequired()
                    .HasColumnName("BSX")
                    .HasMaxLength(50);

                entity.Property(e => e.KhachHang).HasMaxLength(50);

                entity.Property(e => e.LoaiXe).HasMaxLength(50);

                entity.Property(e => e.TaiXe).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
