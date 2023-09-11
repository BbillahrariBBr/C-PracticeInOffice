using SalesAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalesAPI.Controllers
{
    public class HrmEmployeesController : ApiController
    {
        ApplicationDBContext dbContext = new ApplicationDBContext();

        [Authorize]
        //[Route("api/Employee/GetEmployee")]
        public HttpResponseMessage GetEmployeeByID(int id)
        {
            var user = dbContext.HrmEmployees.FirstOrDefault(e=> e.ID == id);   
            return Request.CreateResponse(HttpStatusCode.OK,user);
        }

        [Authorize]
        //[Route("api/Employee/GetEmployees")]
        public HttpResponseMessage GetEmployees()
        {
            var user = dbContext.HrmEmployees.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, user);
        }


    }
}
