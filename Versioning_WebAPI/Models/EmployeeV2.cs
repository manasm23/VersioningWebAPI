using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versioning_WebAPI.Models
{
    public class EmployeeV2
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}