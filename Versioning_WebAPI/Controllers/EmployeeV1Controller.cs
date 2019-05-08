using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Versioning_WebAPI.Models;

namespace Versioning_WebAPI.Controllers
{
    public class EmployeeV1Controller : ApiController
    {
        readonly List<EmployeeV1> lstEmp = new List<EmployeeV1>()
        {
            new EmployeeV1{ID=1,Name="Manas",Age=37,City="Pune",State="Maharashtra"},
            new EmployeeV1{ID=2,Name="Payal",Age=20,City="New Delhi", State="Delhi"},
        };

        public IEnumerable<EmployeeV1> Get()
        {
            return lstEmp;
        }

        public EmployeeV1 Get(int ID)
        {
            return lstEmp.FirstOrDefault(x => x.ID == ID);
        }
    }
}
