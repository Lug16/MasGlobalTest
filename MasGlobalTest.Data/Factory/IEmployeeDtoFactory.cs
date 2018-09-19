using MasGlobalTest.Data.Dto;
using MasGlobalTest.Data.Model;

namespace MasGlobalTest.Data.Factory
{
    public interface IEmployeeDtoFactory
    {
        EmployeeDto CreateEmployee(Employee employee);
    }
}
