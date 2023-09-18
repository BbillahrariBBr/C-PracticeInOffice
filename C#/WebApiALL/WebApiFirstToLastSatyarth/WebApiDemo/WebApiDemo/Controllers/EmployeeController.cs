using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class EmployeeController : ApiController
    {
        //data for model
        public static List<Employee> employees = new List<Employee>
        {
            new Employee{Id = 1001, Name = "abc", City = "Dhaka", IsActive = true},
            new Employee{Id = 1002, Name = "def", City = "Nganj", IsActive = true},
            new Employee{Id = 1003, Name = "geh", City = "Old Dhaka", IsActive = true},
            new Employee{Id = 1004, Name = "ijk", City = "Mganj", IsActive = true},
            new Employee{Id = 1005, Name = "lmn", City = "Fpur", IsActive = true},
            new Employee{Id = 1006, Name = "opq", City = "Spur", IsActive = true},
        };

        //verb

        // GET: api/Employee
        public List<Employee> Get()
        {
            return employees;
        }

        // GET: api/Employee/id
        public Employee Get(int id) {
            return employees.FirstOrDefault(x => x.Id == id);

        }

        // POST : api/Employee
        public void Post(Employee employee)
        {
            employees.Add(employee);
        }

        //PUT: api/Employee/1001
        public void Put(int id,  Employee employee)
        {
            var emp = employees.FirstOrDefault(x => x.Id == id);
            if(emp != null)
            {
                emp.Name = employee.Name;
                emp.City = employee.City;
                emp.IsActive = employee.IsActive;
            }
        }

        //DELETE: api/Employee/1001
        public void Delete(int id)
        {
            var emp = employees.FirstOrDefault(x=> x.Id == id); 
            if(emp != null)
            {
                employees.Remove(emp);
            }
        }
    }
}
