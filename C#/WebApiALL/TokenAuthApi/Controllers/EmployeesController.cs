using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TokenAuthApi.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> GetEmployees()
        {
            using (BakiDbEntities entities = new BakiDbEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}
