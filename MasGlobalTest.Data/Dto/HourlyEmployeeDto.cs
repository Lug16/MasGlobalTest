using System.Runtime.Serialization;

namespace MasGlobalTest.Data.Dto
{
    [KnownType(typeof(HourlyEmployeeDto))]
    public class HourlyEmployeeDto : EmployeeDto
    {
        public override decimal AnnualSalary => HourlySalary * 120 * 12; 
    }
}
