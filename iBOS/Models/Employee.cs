using System.ComponentModel.DataAnnotations;

namespace iBOS.Models;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    public string EmployeeName { get; set; }
    [Required]
    public string EmployeeCode { get; set; }
    public double EmployeeSalary { get; set; }
    public int SupervisorId { get; set; }
    public List<EmployeeAttendance> EmployeeAttendances { get; set; }
}
