using Payroll.Entities;

namespace Payroll.Application.Interfaces
{
    public interface IEmployeeStorage
    {
        Employee GetEmployee(Guid employeeId);
    }
}
