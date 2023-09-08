using iBOS.Models;
using iBOS.Models.DataSeed;
using Microsoft.EntityFrameworkCore;

namespace iBOS.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        modelBuilder.ApplyConfiguration(new EmployeeAttendanceConfiguration());
    }
    public DbSet<Employee> tblEmployee { get; set; }
    public DbSet<EmployeeAttendance> tblEmployeeAttendance { get; set; }
}
