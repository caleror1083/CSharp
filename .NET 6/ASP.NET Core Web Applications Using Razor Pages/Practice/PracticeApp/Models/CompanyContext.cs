using Microsoft.EntityFrameworkCore;

namespace PracticeApp.Models
{
    public partial class CompanyContext : DbContext
    {
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;

        public CompanyContext() {}
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
                entity.Property(e => e.DepartmentName).HasMaxLength(500);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
                entity.Property(e => e.DateofJoining).HasColumnType("date");
                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
                entity.Property(e => e.DepartmentName).HasMaxLength(500);
                entity.Property(e => e.EmployeeName).HasMaxLength(500);
                entity.Property(e => e.PhotoFileName).HasMaxLength(500);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}