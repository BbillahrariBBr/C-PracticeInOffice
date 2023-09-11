using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalesAPI.Models
{
    public class s_User
    {
        [Key]
        public Int64 u_ID { get; set; }
        public string u_LoginName { get; set; }
        public string u_Password { get; set; }
        public bool u_Status { get; set; }
    }
}