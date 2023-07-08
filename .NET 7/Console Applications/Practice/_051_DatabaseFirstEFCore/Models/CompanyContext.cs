using Microsoft.EntityFrameworkCore;

namespace _051_DatabaseFirstEFCore.Models;

public partial class CompanyContext : DbContext
{
    public virtual DbSet<Departments> Departments { get; set; } = null!;
	public virtual DbSet<Employees> Employees { get; set; } = null!;

	public CompanyContext() {}

	public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) {}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=Company;Trusted_Connection=true;");
		}
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Departments>(entity =>
        {
			entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
			entity.Property(e => e.DepartmentName).HasMaxLength(500);
		});

		modelBuilder.Entity<Employees>(entity =>
		{
			entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
			entity.Property(e => e.DateofJoining).HasColumnType("date");
			entity.Property(e => e.DepartmentName).HasMaxLength(500);
			entity.Property(e => e.EmployeeName).HasMaxLength(500);
			entity.Property(e => e.PhotoFileName).HasMaxLength(500);
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}