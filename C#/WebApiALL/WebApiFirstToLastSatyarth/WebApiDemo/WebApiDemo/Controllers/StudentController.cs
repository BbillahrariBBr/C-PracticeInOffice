using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class StudentController : ApiController
    {
        // data for model
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1001,Name= "Ayman", Roll= 12, isActive= true },
            new Student { Id = 1002, Name = "Sadik", Roll = 13, isActive= true},
            new Student { Id = 1003, Name = "Sadman", Roll = 14, isActive= true},
            new Student { Id = 1004, Name = "Sakib", Roll= 15, isActive= false},
        };


        //verb

        //GET: api/Student
        public List<Student> Get()
        {
            return students;
        }

        //GET: api/Student/1001
        public Student Get(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
        }

        //POST: api/Student
        public void Post(Student student)
        {
            students.Add(student);
        }

        //PUT : api/Student/1001
        public void Put(int id, Student student) {
            var std = students.FirstOrDefault(x => x.Id == id);

            if(std != null)
            {
                std.Name = student.Name;
                std.Roll = student .Roll;
                std.isActive = student.isActive;
            }
        }

        //DELETE: api/Student/1001
        public void Delete(int id)
        {
            var std = students.FirstOrDefault(x=> x.Id == id);
            if(std != null)
            {
                students.Remove(std);
            }
        }
    }
}
