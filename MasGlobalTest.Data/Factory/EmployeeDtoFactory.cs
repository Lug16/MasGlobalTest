using MasGlobalTest.Data.Dto;
using MasGlobalTest.Data.Enums;
using MasGlobalTest.Data.Mapper;
using MasGlobalTest.Data.Model;
using System;

namespace MasGlobalTest.Data.Factory
{
    public class EmployeeDtoFactory : IEmployeeDtoFactory
    {
        public EmployeeDto CreateEmployee(Employee employee)
        {
            var contractType = (ContractTypes)Enum.Parse(typeof(ContractTypes), employee.ContractTypeName);

            switch (contractType)
            {
                case ContractTypes.HourlySalaryEmployee:
                    return employee.ToDto<HourlyEmployeeDto>();
                case ContractTypes.MonthlySalaryEmployee:
                    return employee.ToDto<MonthlyEmployeeDto>();
                default:
                    break;
            }

            return null;
        }
    }
}
