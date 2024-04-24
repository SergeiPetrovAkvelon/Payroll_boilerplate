using Payroll.Application.Interfaces;

namespace Payroll.Entities
{
    public class EffortReport
    {
        private ICalculateStrategy calculateStrategy;

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
        /// Salary of the employee.
        /// </summary>
        public decimal Salary
        {
            get
            {
                return Payment * EffortTime;
            }
        }

        public EffortReport(ICalculateStrategy calculateStrategy)
        {
            this.calculateStrategy = calculateStrategy;
        }

        /// <summary>
        /// Calculate the payment rate.
        /// </summary>
        /// <returns></returns>
        public string CalculatePaymentRate()
        {
            return calculateStrategy.CalculatePaymentRate(Payment);
        }

        /// <summary>
        /// Calculate the effort.
        /// </summary>
        /// <returns></returns>
        public string CalculateEffort()
        {
            return calculateStrategy.CalculateEffort(EffortTime);
        }
    }
}
