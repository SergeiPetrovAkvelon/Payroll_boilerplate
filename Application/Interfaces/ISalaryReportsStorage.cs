using Payroll.Entities;

namespace Payroll.Application.Interfaces
{
    public interface ISalaryReportsStorage
    {
        void SaveSalaryReport(SalaryReport salaryReport);
    }
}
