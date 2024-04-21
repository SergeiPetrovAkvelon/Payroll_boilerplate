using Payroll.Entities;

namespace Payroll.Application.Interfaces
{
    public interface IEffortReportProvider
    {
        IEnumerable<EffortReport> GetEffortReports();
    }
}
