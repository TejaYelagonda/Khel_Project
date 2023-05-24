using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO;
using System.Collections.Generic;

namespace Khel_Project.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ADO_DBController : ControllerBase
    {
        private readonly IEmpServices  _empservices;
        public ADO_DBController(IEmpServices empservices)
        {
            _empservices = empservices;
        }
        [HttpGet("GetEmployeeDetails")]
        public List<EmpDTO> GetEmp()
        {
            var data = _empservices.GetEmp();
            return data;
        }
    }
}