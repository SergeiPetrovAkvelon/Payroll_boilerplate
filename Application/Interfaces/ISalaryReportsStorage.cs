using Payroll.Entities;

namespace Payroll.Application.Interfaces
{
    public interface ISalaryReportsStorage
    {
        /// <summary>
        /// Save salary report.
        /// </summary>
        /// <param name="salaryReport"></param>
        void SaveSalaryReport(SalaryReport salaryReport);
    }
}
