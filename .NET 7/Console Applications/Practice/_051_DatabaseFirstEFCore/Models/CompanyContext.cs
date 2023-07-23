using Microsoft.EntityFrameworkCore;

namespace _051_DatabaseFirstEFCore.Models;

public partial class CompanyContext : DbContext
{
    public virtual DbSet<Department> Departments { get; set; } = null!;
	public virtual DbSet<Employee> Employees { get; set; } = null!;

	public CompanyContext() {}
	public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) {}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseSqlServer("Server=localhost;Database=Company;Trusted_Connection=True;Encrypt=False;");
		}
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Department>(entity =>
        {
			entity.Property(e => e.DepartmentID);
			entity.Property(e => e.DepartmentName).HasMaxLength(500);
		});

		modelBuilder.Entity<Employee>(entity =>
		{
			entity.Property(e => e.EmployeeID);
			entity.Property(e => e.EmployeeName).HasMaxLength(500);
			entity.Property(e => e.DepartmentName).HasMaxLength(500);
			entity.Property(e => e.DateofJoining).HasColumnType("date");
			entity.Property(e => e.PhotoFileName).HasMaxLength(500);
            entity.Property(e => e.DepartmentID);
            entity.Property(e => e.SSN).HasMaxLength(50);
		});
		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}