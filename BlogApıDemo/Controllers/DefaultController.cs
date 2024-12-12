using BlogApıDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApıDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee emplyoee)
        {
            using var c = new Context();
            c.Add(emplyoee);

            //Değişiklikleri veritabanına kaydet
            c.SaveChanges();
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new Context();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            } 
            else
            {
                return Ok(employee);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            using var c = new Context();
            var employee = c.Employees.Find(id);
            if(employee == null)
            {
                return NotFound();
            } else
            {
                c.Remove(id);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult UpdateEmployee (Employee employee)
        {
            using var c = new Context();
            var emp = c.Employees.Find(employee.ID);
            if (employee == null)
            {
                return NotFound();
            } else
            {
                emp.Name = employee.Name;

                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }
        }

    }
}
