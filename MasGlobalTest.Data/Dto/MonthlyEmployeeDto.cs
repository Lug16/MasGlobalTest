namespace MasGlobalTest.Data.Dto
{
    public class MonthlyEmployeeDto : EmployeeDto
    {
        public override decimal AnnualSalary => base.MonthlySalary * 12; 
    }
}
