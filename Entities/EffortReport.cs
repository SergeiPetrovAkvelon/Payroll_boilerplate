using Payroll.Application.Enums;

namespace Payroll.Entities
{
    public class EffortReport
    {
        /// <summary>
        /// Unique identifier of the employee.
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Effort time made by the employee for the reporting period.
        /// </summary>
        public decimal EffortTime { get; set; }
        /// <summary>
        /// Payment rate at which the employee is paid.
        /// </summary>
        public decimal Payment { get; set; }
        /// <summary>
        /// Type of employees.
        /// </summary>
        public EmployeesType EmployeeType { get; set; }
        /// <summary>
        /// Salary of the employee.
        /// </summary>
        public decimal Salary
        {
            get
            {
                return Payment * EffortTime;
            }
        }
/// <summary>
/// Calculate the payment rate.
/// </summary>
/// <returns></returns>
        public string CalculatePaymentRate()
        {
            return $"{Payment} {(EmployeeType == EmployeesType.Hourly ? "$ / hour" : "$ / month")}";
        }

        public string CalculateEffort()
        {
            return $"{EffortTime} {(EmployeeType == EmployeesType.Hourly ? "hours" : "months")}";
        }
    }
}
