namespace Payroll.Entities
{
    public class SalaryReport
    {
        /// <summary>
        /// Unique identifier of the employee.
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Employee's position.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Employee's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Effort made by the employee for the reporting period.
        /// </summary>
        public string Effort { get; set; }

        /// <summary>
        /// The rate at which the employee is paid, e.g. "10 $ / hour" or "1000 $ / month".
        /// </summary>
        public string PaymentRate { get; set; }

        /// <summary>
        /// The employee's salary for the reporting period.
        /// </summary>
        public decimal Salary { get; set; }
    }
}
