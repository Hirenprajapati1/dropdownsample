using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dropdowndata.repo;
using dropdowndata.Mod.commen;
     

namespace dropdowndata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowMyOrigin")]

    public class DefaultController : ControllerBase
    {
        private readonly Idepartmentrepo _departmentrepo;

        public DefaultController(Idepartmentrepo departmentrepo)
        {
            _departmentrepo = departmentrepo;
        }

        [HttpGet("GetDepartment")]
        public List<Mod.commen.TblDepartment> GetDepartments()
        {
            return _departmentrepo.GetDepartment();
        }

    }
}