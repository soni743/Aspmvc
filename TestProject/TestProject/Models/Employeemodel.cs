using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestProject.Models
{
    public class Employeemodel
    {
        
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public Int64 Contactno { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }

        public string languages { get; set; }
    }
}