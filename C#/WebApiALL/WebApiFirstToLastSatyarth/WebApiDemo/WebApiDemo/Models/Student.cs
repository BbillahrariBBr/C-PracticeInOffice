using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Roll { get; set; }
        public Boolean isActive { get; set; }
    }
}