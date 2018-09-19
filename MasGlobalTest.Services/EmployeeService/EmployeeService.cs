using MasGlobalTest.Data.Dto;
using MasGlobalTest.Data.Factory;
using MasGlobalTest.Data.Model;
using MasGlobalTest.Tools.Configuration;
using MasGlobalTest.Tools.Connectivity;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MasGlobalTest.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IApiService apiService;
        private readonly IConfigHandler configHandler;
        private readonly IEmployeeDtoFactory employeeDtoFactory;

        public EmployeeService(IApiService apiService, IConfigHandler configHandler, IEmployeeDtoFactory employeeDtoFactory)
        {
            this.apiService = apiService;
            this.configHandler = configHandler;
            this.employeeDtoFactory = employeeDtoFactory;
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            var response = await apiService.Invoke<IEnumerable<Employee>>(HttpMethod.Get, configHandler.GetConfigValue<string>("MasGlobalTestApiEmployeesUrl"));

            var result = response.Select(r => employeeDtoFactory.CreateEmployee(r));

            return result;
        }
    }
}
