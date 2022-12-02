using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Student_GUI
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=sdtudent_db")
        {
        }

        public virtual DbSet<BIEN_LAI> BIEN_LAI { get; set; }
        public virtual DbSet<CA_HOC> CA_HOC { get; set; }
        public virtual DbSet<DANG_KI> DANG_KI { get; set; }
        public virtual DbSet<DAY_HOC> DAY_HOC { get; set; }
        public virtual DbSet<DIEN_GIAM_PHI> DIEN_GIAM_PHI { get; set; }
        public virtual DbSet<GIAM_PHI> GIAM_PHI { get; set; }
        public virtual DbSet<GIAO_VIEN> GIAO_VIEN { get; set; }
        public virtual DbSet<HOC_VIEN> HOC_VIEN { get; set; }
        public virtual DbSet<KHOA_HOC> KHOA_HOC { get; set; }
        public virtual DbSet<KITHI> KITHIs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<LOPHOC> LOPHOCs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<PHANCONG> PHANCONGs { get; set; }
        public virtual DbSet<PHONGHOC> PHONGHOCs { get; set; }
        public virtual DbSet<THI> THIs { get; set; }
        public virtual DbSet<TINHTRANGPHONG> TINHTRANGPHONGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BIEN_LAI>()
                .HasMany(e => e.DANG_KI)
                .WithRequired(e => e.BIEN_LAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BIEN_LAI>()
                .HasMany(e => e.HOC_VIEN)
                .WithMany(e => e.BIEN_LAI)
                .Map(m => m.ToTable("XUAT").MapLeftKey("MABL").MapRightKey("MAHOCVIEN"));

            modelBuilder.Entity<CA_HOC>()
                .HasMany(e => e.PHANCONGs)
                .WithRequired(e => e.CA_HOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CA_HOC>()
                .HasMany(e => e.TINHTRANGPHONGs)
                .WithRequired(e => e.CA_HOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIEN_GIAM_PHI>()
                .HasMany(e => e.GIAM_PHI)
                .WithRequired(e => e.DIEN_GIAM_PHI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAO_VIEN>()
                .HasMany(e => e.DAY_HOC)
                .WithRequired(e => e.GIAO_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOC_VIEN>()
                .HasMany(e => e.THIs)
                .WithRequired(e => e.HOC_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHOA_HOC>()
                .HasMany(e => e.MONHOCs)
                .WithRequired(e => e.KHOA_HOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KITHI>()
                .HasOptional(e => e.THI)
                .WithRequired(e => e.KITHI);

            modelBuilder.Entity<LOPHOC>()
                .HasMany(e => e.TINHTRANGPHONGs)
                .WithRequired(e => e.LOPHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.LOPHOCs)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGHOC>()
                .HasMany(e => e.THIs)
                .WithRequired(e => e.PHONGHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGHOC>()
                .HasMany(e => e.TINHTRANGPHONGs)
                .WithRequired(e => e.PHONGHOC)
                .WillCascadeOnDelete(false);
        }
    }
}
