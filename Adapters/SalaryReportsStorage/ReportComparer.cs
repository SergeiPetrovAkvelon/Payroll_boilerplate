namespace Payroll.Adapters.SalaryReportsStorage
{
    using Payroll.Entities;

    public static class ReportsComparer
    {
        public static bool Equals(SalaryReport leftReport, SalaryReport rightReport)
        {
            return leftReport.Position == rightReport.Position
                && leftReport.Name == rightReport.Name
                && leftReport.Effort == rightReport.Effort
                && leftReport.PaymentRate == rightReport.PaymentRate
                && leftReport.Salary == rightReport.Salary;
        }
    }
}
