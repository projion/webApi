using iBOS.Models;
using iBOS.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace iBOS.Services
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(int id);
        Task<IList<Employee>> GetAllAsync();
        Task<bool> AddAsync(Employee employee);
        Task<bool> UpdateAsync(Employee employee);
        Task<bool> DeleteAsync(Employee employee);
        Task<Employee> Get3rdHighestSalary();
        Task<List<Employee>> AllEmployeeSalary();
        Task<string> EmployeeHierarchy(int EmployeeId, string val = "");
        Task<List<AttendanceReport>> CalculateAttendanceReport();
        Task<Employee> UpdateEmployee(Employee employee);
    }
}
