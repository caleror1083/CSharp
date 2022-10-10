using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dental.Models
{
    public partial class SchedulingContext : DbContext
    {
        public SchedulingContext()
        {
        }

        public SchedulingContext(DbContextOptions<SchedulingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Scheduling;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.LastUpdate)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("lastUpdate");

                entity.Property(e => e.LastUpdateBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("lastUpdateBy");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postalCode");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cityFK");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("appointment");

                entity.Property(e => e.AppointmentId).HasColumnName("appointmentId");

                entity.Property(e => e.Contact)
                    .HasColumnType("text")
                    .HasColumnName("contact");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.End)
                    .HasColumnType("datetime")
                    .HasColumnName("end");

                entity.Property(e => e.LastUpdate)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("lastUpdate");

                entity.Property(e => e.LastUpdateBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("lastUpdateBy");

                entity.Property(e => e.Location)
                    .HasColumnType("text")
                    .HasColumnName("location");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasColumnType("text")
                    .HasColumnName("type");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("url");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("customerFK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userFK");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.City1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.CountryId).HasColumnName("countryId");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.LastUpdate)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("lastUpdate");

                entity.Property(e => e.LastUpdateBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("lastUpdateBy");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("countryFK");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.CountryId).HasColumnName("countryId");

                entity.Property(e => e.Country1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.LastUpdate)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("lastUpdate");

                entity.Property(e => e.LastUpdateBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("lastUpdateBy");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("customer");

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.AddressId).HasColumnName("addressId");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("customerName");

                entity.Property(e => e.LastUpdate)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("lastUpdate");

                entity.Property(e => e.LastUpdateBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("lastUpdateBy");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("addressFK");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("createdBy");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate");

                entity.Property(e => e.LastUpdateBy)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("lastUpdateBy");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
