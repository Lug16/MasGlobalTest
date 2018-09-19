using System.Runtime.Serialization;

namespace MasGlobalTest.Data.Dto
{
    [KnownType(typeof(MonthlyEmployeeDto))]
    public class MonthlyEmployeeDto : EmployeeDto
    {
        public override decimal AnnualSalary => base.MonthlySalary * 12; 
    }
}
