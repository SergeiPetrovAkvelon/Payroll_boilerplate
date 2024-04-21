using Payroll.Entities;

namespace Payroll.Application.Interfaces
{
    public interface IEmployeeStorage
    {
        /// <summary>
        /// Get employee by identifier.
        /// </summary>
        /// <param name="employeeId">Employee ID for search in List</param>
        /// <returns></returns>
        Employee GetEmployee(Guid employeeId);
    }
}
