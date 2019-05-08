using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Versioning_WebAPI.Models;

namespace Versioning_WebAPI.Controllers
{
    public class EmployeeV2Controller : ApiController
    {
        readonly List<EmployeeV2> lstEmp = new List<EmployeeV2>()
        {
            new EmployeeV2{ID=1,FirstName="Manas",LastName="Maratkar",DOB=new DateTime(1982,12,27),City="Pune",State="Maharashtra", Country="India"},
            new EmployeeV2{ID=2,FirstName="Payal",LastName="Jeooghale",DOB=new DateTime(1988,06,27),City="New Delhi", State="Delhi", Country="India"},
        };

        public IEnumerable<EmployeeV2> Get()
        {
            return lstEmp;
        }

        public EmployeeV2 Get(int ID)
        {
            return lstEmp.FirstOrDefault(x => x.ID == ID);
        }
    }
}
