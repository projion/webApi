using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace iBOS.Models;

public class EmployeeAttendance
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    [DataType(DataType.Date)]
    public DateTime AttendanceDate { get; set; }
    public bool IsPresent { get; set; } = false;
    //public bool IsAbsent { get; set; } = !IsPresent; //So,redundency and not needed
    public bool IsOffday { get; set; }
    [JsonIgnore]
    public Employee Employee { get; set; }
}
