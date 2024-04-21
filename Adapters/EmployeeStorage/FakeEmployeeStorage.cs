namespace Payroll.Adapters.EmployeeStorage
{
    using Payroll.Application.Interfaces;
    using Payroll.Entities;

    public class FakeEmployeeStorage : IEmployeeStorage
    {
        private static readonly List<Employee> employees = new List<Employee>
        {
            new Employee()
            {
                Id = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215D"),
            },

            new Employee()
            {
                Id = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215E"),
            },

            new Employee()
            {
                Id = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215F"),
            },

            new Employee()
            {
                Id = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A2160"),
            }
        };

        public Employee GetEmployee(Guid employeeId)
        {
            throw new NotImplementedException("To be implemented");
        }
    }
}
