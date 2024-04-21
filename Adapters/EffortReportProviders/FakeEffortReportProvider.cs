using Payroll.Application.Interfaces;
using Payroll.Entities;

namespace Payroll.Adapters.EffortReportProviders
{
    public class FakeEffortReportProvider : IEffortReportProvider
    {
        public IEnumerable<EffortReport> GetEffortReports()
        {
            return new List<EffortReport>
            {
                new EffortReport
                {
                    EmployeeId = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215D"),
                },
                new EffortReport
                {
                    EmployeeId = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215E"),
                },
                new EffortReport
                {
                    EmployeeId = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215F"),
                },
                new EffortReport
                {
                    EmployeeId = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A2160"),
                },
            };
        }
    }
}
