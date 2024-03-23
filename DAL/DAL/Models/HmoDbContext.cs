using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class HmoDbContext : DbContext
{
    public HmoDbContext()
    {
    }

    public HmoDbContext(DbContextOptions<HmoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CoronaPatient> CoronaPatients { get; set; }

    public virtual DbSet<MemberHmo> MemberHmos { get; set; }

    public virtual DbSet<VaccinatedMbr> VaccinatedMbrs { get; set; }

    public virtual DbSet<Vaccination> Vaccinations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=HMO_DB;Trusted_Connection=True; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CoronaPatient>(entity =>
        {
            entity.HasKey(e => e.CpCode);

            entity.ToTable("Corona_Patients");

            entity.Property(e => e.CpCode).HasColumnName("cpCode");
            entity.Property(e => e.CpDatePositive)
                .HasColumnType("date")
                .HasColumnName("cpDatePositive");
            entity.Property(e => e.CpDateRecovery)
                .HasColumnType("date")
                .HasColumnName("cpDateRecovery");
            entity.Property(e => e.CpMbrCode).HasColumnName("cpMbrCode");

            entity.HasOne(d => d.CpMbrCodeNavigation).WithMany(p => p.CoronaPatients)
                .HasForeignKey(d => d.CpMbrCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Corona_Patients_memberHMO");
        });

        modelBuilder.Entity<MemberHmo>(entity =>
        {
            entity.HasKey(e => e.MbrCode);

            entity.ToTable("memberHMO");

            entity.Property(e => e.MbrCode).HasColumnName("mbrCode");
            entity.Property(e => e.MbrBirthDate)
                .HasColumnType("date")
                .HasColumnName("mbrBirthDate");
            entity.Property(e => e.MbrCity)
                .HasMaxLength(15)
                .HasColumnName("mbrCity");
            entity.Property(e => e.MbrFirstName)
                .HasMaxLength(15)
                .HasColumnName("mbrFirstName");
            entity.Property(e => e.MbrLastName)
                .HasMaxLength(15)
                .HasColumnName("mbrLastName");
            entity.Property(e => e.MbrNumStreet).HasColumnName("mbrNumStreet");
            entity.Property(e => e.MbrPatient).HasColumnName("mbrPatient");
            entity.Property(e => e.MbrPhon)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("mbrPhon");
            entity.Property(e => e.MbrStreet)
                .HasMaxLength(15)
                .HasColumnName("mbrStreet");
            entity.Property(e => e.MbrTel)
                .HasMaxLength(9)
                .IsFixedLength()
                .HasColumnName("mbrTel");
            entity.Property(e => e.MbrTz)
                .HasMaxLength(9)
                .IsFixedLength()
                .HasColumnName("mbrTz");
            entity.Property(e => e.MbrVaccinted).HasColumnName("mbrVaccinted");
        });

        modelBuilder.Entity<VaccinatedMbr>(entity =>
        {
            entity.HasKey(e => e.VmCode);

            entity.ToTable("Vaccinated_Mbr");

            entity.Property(e => e.VmCode).HasColumnName("vmCode");
            entity.Property(e => e.VmDate)
                .HasColumnType("date")
                .HasColumnName("vmDate");
            entity.Property(e => e.VmMbrCode).HasColumnName("vmMbrCode");
            entity.Property(e => e.VmVcCode).HasColumnName("vmVcCode");

            entity.HasOne(d => d.VmMbrCodeNavigation).WithMany(p => p.VaccinatedMbrs)
                .HasForeignKey(d => d.VmMbrCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vaccinated_Mbr_memberHMO");

            entity.HasOne(d => d.VmVcCodeNavigation).WithMany(p => p.VaccinatedMbrs)
                .HasForeignKey(d => d.VmVcCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vaccinated_Mbr_Vaccinations");
        });

        modelBuilder.Entity<Vaccination>(entity =>
        {
            entity.HasKey(e => e.VcCode);

            entity.Property(e => e.VcCode).HasColumnName("vcCode");
            entity.Property(e => e.VcManufacturer)
                .HasMaxLength(10)
                .HasColumnName("vcManufacturer");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
