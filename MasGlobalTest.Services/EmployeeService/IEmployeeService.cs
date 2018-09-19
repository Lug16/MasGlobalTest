using MasGlobalTest.Data.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MasGlobalTest.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployeesAsync(int id);
    }
}
