using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace EmpServices.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (BakiDbEntities entities = new BakiDbEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using (BakiDbEntities entities = new BakiDbEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
