using iBOS.Models;

namespace iBOS.Services
{
    public interface IEmployeeAttendanceRepository
    {
        Task<EmployeeAttendance> GetByIdAsync(int id);
        Task<IList<EmployeeAttendance>> GetAllAsync();
        Task<bool> AddAsync(EmployeeAttendance employeeAttendance);
        Task<bool> UpdateAsync(EmployeeAttendance employeeAttendance);
        Task<bool> DeleteAsync(EmployeeAttendance employeeAttendance);
    }
}
