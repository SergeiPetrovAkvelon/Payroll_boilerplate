namespace Payroll.Entities
{
    public class Employee
    {
        /// <summary>
        /// Unique identifier of the employee.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Employee's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Employee's surname.
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Employee's position.
        /// </summary>
        public string Position { get; set; }
    }
}
