using Microsoft.EntityFrameworkCore;

// Namespaces
namespace PracticeApp.Models
{
	// Classes
    public partial class CompanyContext : DbContext
    {
		// Properties
        public virtual DbSet<Employee> Employees { get; set; } = null!;

		// Constructors(Parameters)
        public CompanyContext() {}
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) {}

		// Methods(Parameters)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
                entity.Property(e => e.DateofJoining).HasColumnType("date");
                entity.Property(e => e.Department).HasMaxLength(500);
                entity.Property(e => e.EmployeeName).HasMaxLength(500);
                entity.Property(e => e.PhotoFileName).HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}