using MasGlobalTest.Data.Dto;
using MasGlobalTest.Data.Model;

namespace MasGlobalTest.Data.Mapper
{
    public static class EmployeeToDto
    {
        public static T ToDto<T>(this Employee employee) where T: EmployeeDto, new()
        {
            return new T
            {
                ContractTypeName = employee.ContractTypeName,
                HourlySalary = employee.HourlySalary,
                Id = employee.Id,
                MonthlySalary = employee.MonthlySalary,
                Name = employee.Name,
                RoleDescription = employee.RoleDescription,
                RoleId = employee.RoleId,
                RoleName = employee.RoleName
            };
        }
    }
}
