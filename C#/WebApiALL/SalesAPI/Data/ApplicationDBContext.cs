using SalesAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace SalesAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext():base("DefaultConnection")
        {
            
            
        }
        public DbSet<s_User> s_User { get; set; }
        public DbSet<HrmEmployees> HrmEmployees { get; set; }
    }
}