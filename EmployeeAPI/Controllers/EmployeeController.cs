using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TblEmployee> GetEmployees()
        {
            return  _context.TblEmployees.ToList();
        }

        [HttpPost]
        public  IActionResult Post(TblEmployee employee)
        {
            try
            {
                _context.Add(employee);
                _context.SaveChanges();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(400);
            }
        }
    }
}
