using Payroll.Entities;

namespace Payroll.Application.Interfaces
{
    public interface IEffortReportProvider
    {
        /// <summary>
        /// Get all effort reports.
        /// </summary>
        /// <returns></returns>
        IEnumerable<EffortReport> GetEffortReports();
    }
}
