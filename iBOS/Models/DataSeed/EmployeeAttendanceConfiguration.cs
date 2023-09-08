using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace iBOS.Models.DataSeed;

public class EmployeeAttendanceConfiguration : IEntityTypeConfiguration<EmployeeAttendance>
{
    public void Configure(EntityTypeBuilder<EmployeeAttendance> builder)
    {
        builder.HasData(
            new EmployeeAttendance { Id = 1, EmployeeId = 502030, AttendanceDate = new DateTime(2023, 6, 24), IsPresent = true, IsOffday = false },
            new EmployeeAttendance { Id = 2, EmployeeId = 502030, AttendanceDate = new DateTime(2023, 6, 25), IsPresent = false, IsOffday = true },
            new EmployeeAttendance { Id = 3, EmployeeId = 502031, AttendanceDate = new DateTime(2023, 6, 25), IsPresent = true, IsOffday = false }
            // Add more seed data as needed
        );
    }
}