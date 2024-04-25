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
                Name = "John",
                Surname = "Doe",
                Position = "COO"
            },

            new Employee()
            {
                Id = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215E"),
                Name = "Jane",
                Surname = "Doe",
                Position = "CTO"
            },

            new Employee()
            {
                Id = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A215F"),
                Name = "John",
                Surname = "Smith",
                Position = "Developer"
            },

            new Employee()
            {
                Id = Guid.Parse("3D808398-1711-4EF8-A6A4-52853F4A2160"),
                Name = "Jane",
                Surname = "Smith",
                Position = "QA"
            }
        };

        /// <summary>
        /// Get employee by Id.
        /// </summary>
        /// <param name="employeeId">Employee ID for search in List</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public Employee GetEmployee(Guid employeeId)
        {
            if (employeeId == Guid.Empty)
            {
                throw new ArgumentException("EmployeeId cannot be empty.");
            }

            try
            {
                var employee = employees.First(e => e.Id == employeeId);
                return employee;
            }
            catch (Exception e)
            {
                throw new ArgumentException("Employee not found.");
            }
        }
    }
}
