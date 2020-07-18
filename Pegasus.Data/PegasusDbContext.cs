using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Pegasus.Data
{
    public partial class PegasusDbContext : DbContext
    {
        public PegasusDbContext(DbContextOptions<PegasusDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<LguProfile> LguProfile { get; set; }
        public virtual DbSet<Barangay> Barangay { get; set; }
        public virtual DbSet<PersonProfile> PersonProfile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite(@"Data Source=pegasus.db;");
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LguProfile>().ToTable("LguProfile");
            modelBuilder.Entity<Barangay>().ToTable("Barangay");
            modelBuilder.Entity<PersonProfile>().ToTable("PersonProfile");
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    }

    #region Entity Classess
    public class LguProfile
    {
        public int Id { get; set; }
        public string LguName { get; set; }
        public string LguAddress { get; set; }
        public string LguLocation { get; set; }
        public string LguLogoPath { get; set; }
        public string LguQrCode { get; set; }
        public DateTime? DateCreated { get; set; }
    }

    public class Barangay
    {
        public int Id { get; set; }
        public string BarangayName { get; set; }
        public string BarangayAddress { get; set; }
        public string BarangayLocation { get; set; }
        public string BarangayLogoPath { get; set; }
        public string BarangayQrCode { get; set; }
        public DateTime? DateCreated { get; set; }
    }

    
    public class PersonProfile
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int? LguId { get; set; }
        public int? BgryId { get; set; }
        public string QrCode { get; set; }
        public string PicPath { get; set; }
        public DateTime? DateCreated { get; set; }
        public virtual LguProfile Lgu { get; set; }
        public virtual Barangay Barangay { get; set; }
        public int? PrincipalPersonId { get; set; }
        public int? QDays { get; set; }
        public DateTime? QDateStarted { get; set; }
        public DateTime? QDateEnded { get; set; }
        public string PersonStatus { get; set; }

    }
    
    #endregion
}
