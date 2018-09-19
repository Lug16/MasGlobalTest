namespace MasGlobalTest.Data.Dto
{
    public class HourlyEmployeeDto : EmployeeDto
    {
        public override decimal AnnualSalary => HourlySalary * 120 * 12; 
    }
}
