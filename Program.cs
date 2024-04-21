using Payroll.Adapters.EffortReportProviders;
using Payroll.Adapters.EmployeeStorage;
using Payroll.Adapters.SalaryReportsStorage;
using Payroll.Application;
using Payroll.Application.Interfaces;

namespace Payroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeStorage employeeStorage = new FakeEmployeeStorage();
            IEffortReportProvider effortReportProvider = new FakeEffortReportProvider();
            ISalaryReportsStorage salaryReportsStorage = new FakeSalaryReportsStorage();

            var createSalaryReport = new CreateSalaryReport(employeeStorage, salaryReportsStorage);
            createSalaryReport.CreateAndSaveSalaryReport(effortReportProvider);
        }
    }
}
