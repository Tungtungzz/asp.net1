using System;
using Microsoft.EntityFrameworkCore;
using KiemTra.Entities;
namespace KiemTra.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

