using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ERP.Core.Domains;

namespace ERP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<SystemInfo> SystemInfos { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<RoleEmployee> RoleEmployees { get; set; }
        public DbSet<EmployeeDocument> EmployeeDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Employee-SystemInfo (One-to-Many)
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.SystemInfo)
                .WithMany(s => s.Employees)
                .HasForeignKey(e => e.SystemId);

            // Employee-EmployeeDocument (One-to-Many)
            modelBuilder.Entity<EmployeeDocument>()
                .HasOne(ed => ed.Employee)
                .WithMany(e => e.EmployeeDocuments)
                .HasForeignKey(ed => ed.EmployeeId);

            // RoleEmployee (Many-to-Many between Role and Employee)
            modelBuilder.Entity<RoleEmployee>()
                .HasKey(re => new { re.RoleId, re.EmployeeId });

            modelBuilder.Entity<RoleEmployee>()
                .HasOne(re => re.Role)
                .WithMany(r => r.RoleEmployees)
                .HasForeignKey(re => re.RoleId);

            modelBuilder.Entity<RoleEmployee>()
                .HasOne(re => re.Employee)
                .WithMany(e => e.RoleEmployees)
                .HasForeignKey(re => re.EmployeeId);

            // Configure composite key for RolePermission
            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            // Configure relationships
            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.RoleId);

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.PermissionId);
        }
    }
}
