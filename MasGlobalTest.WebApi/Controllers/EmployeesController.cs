﻿using MasGlobalTest.Services.EmployeeService;
using System.Threading.Tasks;
using System.Web.Http;

namespace MasGlobalTest.WebApi.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var result = await employeeService.GetEmployeesAsync();
            return Ok(result);
        }
    }
}
