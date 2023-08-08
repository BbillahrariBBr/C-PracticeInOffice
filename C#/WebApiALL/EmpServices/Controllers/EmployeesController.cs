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


        public HttpResponseMessage Get(int id)
        {
            using (BakiDbEntities entities = new BakiDbEntities())
            { 
                var entity = entities.Employees.FirstOrDefault(x => x.Id == id);
                if (entity != null) {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound,"Employee with Id = " + id.ToString() + " not found.");
                }
            }
        }

        //public Employee Get(int id)
        //{
        //    using (BakiDbEntities entities = new BakiDbEntities())
        //    {
        //        return entities.Employees.FirstOrDefault(e => e.Id == id);
        //    }
        //}

        //public void Post([FromBody] Employee employee)
        //{
        //    using (BakiDbEntities entity = new BakiDbEntities())
        //    {
        //        entity.Employees.Add(employee);
        //        entity.SaveChanges();
        //    }
        //}

        public HttpResponseMessage Post([FromBody]Employee employee)
        {
            try
            {

            
                using (BakiDbEntities entity = new BakiDbEntities())
                {
                    entity.Employees.Add(employee);
                    entity.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created,employee);
                    message.Headers.Location = new Uri(Request.RequestUri +"/"+ employee.Id.ToString());
                    return message;
                }
            }

            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (BakiDbEntities entities = new BakiDbEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.Id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee With id = " + id.ToString() + " not found");

                    }
                    else
                    {
                        entities.Employees.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }


                }

            }

            catch( Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }

        public HttpResponseMessage Put(int id, [FromBody]Employee employee)
        {
            try {
                using (BakiDbEntities entities = new BakiDbEntities())
                {
                    var entity = entities.Employees.FirstOrDefault(e => e.Id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Employee with Id= " + id.ToString() + " not found");
                    }

                    else
                    {
                        entity.FirstName = employee.FirstName;
                        entity.LastName = employee.LastName;
                        entity.Gender = employee.Gender;
                        entity.Salary = employee.Salary;
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }


                }
            }

            catch ( Exception ex ) { 
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest,ex);
            }
            
        }
    }
}
