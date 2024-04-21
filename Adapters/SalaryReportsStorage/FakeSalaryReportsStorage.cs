namespace Payroll.Adapters.SalaryReportsStorage
{
    using Payroll.Application.Interfaces;
    using Payroll.Entities;

    public class FakeSalaryReportsStorage : ISalaryReportsStorage
    {
        private static readonly SalaryReport[] ExpectedReports = new[] {
            new SalaryReport
            {
                Position = "COO",
                Name = "John Doe",
                Effort = "1 months",
                PaymentRate = "1000 $ / month",
                Salary = 1000
            },

            new SalaryReport
            {
                Position = "CTO",
                Name = "Jane Doe",
                Effort = "1 months",
                PaymentRate = "2000 $ / month",
                Salary = 2000
            },

            new SalaryReport
            {
                Position = "Developer",
                Name = "John Smith",
                Effort = "102 hours",
                PaymentRate = "10 $ / hour",
                Salary = 1020
            },

            new SalaryReport
            {
                Position = "QA",
                Name = "Jane Smith",
                Effort = "123 hours",
                PaymentRate = "20 $ / hour",
                Salary = 2460
            }
        };

        public void SaveSalaryReport(SalaryReport salaryReport)
        {
            var expectedReport = ExpectedReports.FirstOrDefault(r => r.Name == salaryReport.Name);
            if (expectedReport is { } && ReportsComparer.Equals(salaryReport, expectedReport))
            {
                Console.WriteLine($"Report for {salaryReport.Name} is correct");
                return;
            }

            Console.WriteLine($"Incorrect report for {salaryReport.Name}");
        }
    }
}
