using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MasGlobalTest.Data.Model;
using MasGlobalTest.Tools.Configuration;
using MasGlobalTest.Tools.Connectivity;

namespace MasGlobalTest.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IApiService apiService;
        private readonly IConfigHandler configHandler;

        public EmployeeService(IApiService apiService, IConfigHandler configHandler)
        {
            this.apiService = apiService;
            this.configHandler = configHandler;
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            var response = await apiService.Invoke<Employee>(HttpMethod.Get, configHandler.GetConfigValue<string>("MasGlobalTestApiEmployeesUrl"));
        }
    }
}
