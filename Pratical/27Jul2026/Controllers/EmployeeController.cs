using Microsoft.AspNetCore.Mvc;
using _27Jul2026.Models;

namespace _27Jul2026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 101,
                Name = "Rahul",
                LastName = "Patil",
                Dept = "CSE",
                PhoneNum = "7896541230"
            },

            new Employee()
            {
                Id = 102,
                Name = "Anshuman",
                LastName = "Sharma",
                Dept = "IT",
                PhoneNum = "9876543210"
            },

            new Employee()
            {
                Id = 103,
                Name = "Ammar",
                LastName = "Khan",
                Dept = "ECE",
                PhoneNum = "9988776655"
            }
        };

        // GET : api/Employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(employees);
        }

        // GET : api/Employee/101
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);

            if (emp == null)
                return NotFound("Employee Not Found");

            return Ok(emp);
        }

        // POST : api/Employee
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        // PUT : api/Employee/101
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);

            if (emp == null)
                return NotFound("Employee Not Found");

            emp.Name = employee.Name;
            emp.LastName = employee.LastName;
            emp.Dept = employee.Dept;
            emp.PhoneNum = employee.PhoneNum;

            return Ok(emp);
        }

        // DELETE : api/Employee/101
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);

            if (emp == null)
                return NotFound("Employee Not Found");

            employees.Remove(emp);

            return Ok("Employee Deleted Successfully");
        }
    }
}