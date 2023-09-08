using iBOS.DataAccess;
using iBOS.Models;
using iBOS.Services;
using iBOS.Services.Repositories;
using iBOS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace iBOS.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly AppDbContext _context;
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeController(IEmployeeRepository employeeRepo, AppDbContext context)
        {
            _employeeRepo = employeeRepo;
            _context = context;
        }

        // PUT api/<EmployeeController>/5
        //[Route("api/PutAPI01")]
        [HttpPut("UpdateEmployee/{id}")]
        public async Task<ActionResult<Employee>> PutAPI01(int id, Employee employee)
        {
            //if (id != employee.EmployeeId)
            if (employee.EmployeeId == null)
            {
                return BadRequest();
            }
            try
            {
                var data = await _employeeRepo.UpdateEmployee(employee);
                return Ok(data);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
                throw;
            }
            //return BadRequest();
        }

        // GET api/<EmployeeController>/5
        //[HttpGet]
        //[Route("api/API02")]
        //[Route("Get3rdHighestSalary")]
        [HttpGet("Get3rdHighestSalary")]
        public async Task<ActionResult<Employee>> API02()
        {
            return await _employeeRepo.Get3rdHighestSalary(); ;
        }

        //GET: api/<EmployeeController>
        //[HttpGet("All-employee-salary")]
        [HttpGet("AllEmployeeSalary")]
        public async Task<ActionResult<List<Employee>>> API03()
        {
            var data = await _employeeRepo.AllEmployeeSalary();
            return data;
        }



        // POST api/<EmployeeController>
        //[HttpGet("AttendanceReport")]
        [HttpGet("AttendanceReport")]
        public async Task<ActionResult<List<AttendanceReport>>> API04()
        {
            var data = await _employeeRepo.CalculateAttendanceReport();

            if (data.Count == 0)
                return NotFound();
            return data;
        }

        [HttpGet("EmployeeHierarchy")]
        public async Task<ActionResult<string>> API05(int EmployeeId)
        {
            return await _employeeRepo.EmployeeHierarchy(EmployeeId, null);
        }
    }
}
