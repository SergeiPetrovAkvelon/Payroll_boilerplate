using Payroll.Application.Interfaces;
using Payroll.Entities;

namespace Payroll.Application
{
    public class CreateSalaryReport
    {
        private readonly IEmployeeStorage employeeStorage;
        private readonly ISalaryReportsStorage salaryReportStorage;

        public CreateSalaryReport(
            IEmployeeStorage employeeStorage,
            ISalaryReportsStorage salaryReportStorage)
        {
            this.employeeStorage = employeeStorage;
            this.salaryReportStorage = salaryReportStorage;
        }

        /// <summary>
        /// Fix all the boilerplate code in this method.
        /// </summary>
        /// <param name="effortProvider"></param>
        public void CreateAndSaveSalaryReport(IEffortReportProvider effortProvider)
        {
            var effortRecords = effortProvider.GetEffortReports();

            foreach (var effortRecord in effortRecords)
            {
                var employee = employeeStorage.GetEmployee(Guid.Empty);

                var salaryReport = new SalaryReport
                {
                };

                this.salaryReportStorage.SaveSalaryReport(salaryReport);
            }
        }
    }
}
