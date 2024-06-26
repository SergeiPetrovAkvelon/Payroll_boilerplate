﻿using Payroll.Application.Interfaces;
using Payroll.Application.Strategy;
using Payroll.Entities;

namespace Payroll.Adapters.EffortReportProviders
{
    public class FakeEffortReportProvider : IEffortReportProvider
    {
        /// <summary>
        /// Get all effort reports.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EffortReport> GetEffortReports()
        {
            return new List<EffortReport>
            {
                new EffortReport(new SalariedCalculateStrategy())
                {
                    EmployeeId = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215D"),
                    EffortTime = 1,
                    Payment = 1000,
                },
                new EffortReport(new SalariedCalculateStrategy())
                {
                    EmployeeId = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215E"),
                    EffortTime = 1,
                    Payment = 2000,
                },
                new EffortReport(new HourlyCalculateStrategy()) 
                {
                    EmployeeId = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215F"),
                    EffortTime = 102,
                    Payment = 10,
                },
                new EffortReport(new HourlyCalculateStrategy()) 
                {
                    EmployeeId = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A2160"),
                    EffortTime = 123,
                    Payment = 20,
                },
            };
        }
    }
}

