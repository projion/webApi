using iBOS.DataAccess;
using iBOS.Models;
using Microsoft.EntityFrameworkCore;

namespace iBOS.Services.Repositories
{
    public class EmployeeAttendanceRepository : IEmployeeAttendanceRepository
    {
        private readonly AppDbContext _context;

        public EmployeeAttendanceRepository(AppDbContext context)
        {
            _context = context;
        }

        //private readonly DbSet<EmployeeAttendance> _dbSet;


        #region CRUD functionality
        public async Task<bool> AddAsync(EmployeeAttendance employeeAttendance)
        {
            await _context.AddAsync(employeeAttendance);
            return true;
        }


        public async Task<IList<EmployeeAttendance>> GetAllAsync()
        {
            return await _context.tblEmployeeAttendance.ToListAsync();
        }

        public async Task<EmployeeAttendance> GetByIdAsync(int id)
        {
            return await _context.tblEmployeeAttendance.FindAsync(id);
        }

        public async Task<bool> DeleteAsync(EmployeeAttendance employeeAttendance)
        {
            var data = await GetByIdAsync(employeeAttendance.EmployeeId);
            if (data != null)
            {
                _context.tblEmployeeAttendance.Remove(data);
                //await Task.CompletedTask;
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateAsync(EmployeeAttendance employeeAttendance)
        {
            var data = await GetByIdAsync(employeeAttendance.EmployeeId);
            if (data != null)
            {
                _context.tblEmployeeAttendance.Update(data);
                //await Task.CompletedTask;
                return true;
            }
            return false;
        }
        #endregion
    }
}
