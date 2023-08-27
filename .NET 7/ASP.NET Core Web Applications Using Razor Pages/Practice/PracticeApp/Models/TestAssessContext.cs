using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PracticeApp.Models;

public partial class TestAssessContext : DbContext
{
    public virtual DbSet<ExemptionApplication> ExemptionApplications { get; set; }

    public TestAssessContext() {}
    public TestAssessContext(DbContextOptions<TestAssessContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExemptionApplication>(entity =>
        {
            entity.HasKey(e => e.VersionId);

            entity.ToTable("ExemptionApplication");

            entity.Property(e => e.VersionId).ValueGeneratedNever();
            entity.Property(e => e.ApplicationReference)
                .HasMaxLength(255)
                .IsFixedLength();
            entity.Property(e => e.ExemptionApplicationId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ExemptionApplicationID");
            entity.Property(e => e.PropertyId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("PropertyID");
            entity.Property(e => e.YearId)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}