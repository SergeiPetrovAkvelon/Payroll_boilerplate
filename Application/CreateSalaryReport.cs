using Payroll.Application.Enums;
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
        /// Create and save salary report for all employees.
        /// </summary>
        /// <param name="effortProvider"></param>
        public void CreateAndSaveSalaryReport(IEffortReportProvider effortProvider)
        {
            var effortRecords = effortProvider.GetEffortReports();

            foreach (var effortRecord in effortRecords)
            {
                var employee = employeeStorage.GetEmployee(effortRecord.EmployeeId);

                var salaryReport = GenerateSalaryReport(employee, effortRecord);

                this.salaryReportStorage.SaveSalaryReport(salaryReport);
            }
        }

        /// <summary>
        /// Generate salary report for an employee based on effort record.
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="effortRecord"></param>
        /// <returns></returns>

        private SalaryReport GenerateSalaryReport(Employee employee, EffortReport effortRecord)
        {

            return new SalaryReport(){
                EmployeeId = employee.Id,
                Position = employee.Position,
                Name = $"{employee.Name} {employee.Surname}",
                Effort = effortRecord.CalculateEffort(),
                PaymentRate = effortRecord.CalculatePaymentRate(),
                Salary = effortRecord.Salary
            };
        }
    }
}
