# Payroll project

A simple salary report generator for a small company.

## Implementation details

1. the company has a service to acquire and summarize the monthly effort for each employee. In this application,
   the service is abstracted by the `IEffortProvider` interface.
1. The company has a service to visualize the Salary report, which works with its own storage,
   that is abstracted by the `ISalaryReportsStorage` interface.
1. There is a dedicated employee details storage, that is abstracted by the `IEmployeesStorage` interface.
1. For now, we provide fake implementations for all external services
   at the adapter's layer. The Fake Salary Report storage is implemented as a report validity checker.

## Acceptance criteria

1. The company employs 2 types of employees: salaried and hourly:
	- Salaried employees are paid a fixed amount every month.
	- Hourly employees are paid by the hour.
1. Implement required entities, representing employees and effort report records.
	- Carefully design the classes using inheritance and polymorphism.
1. Implement the business logic to calculate the salary for each employee.

## Notes

1. The boilerplate code provided should be considered as a hint and may be changed as needed.
1. The logic behind the FakeSalaryReportsStorage should not be changed, since it will be used as the
   final implementation validity check.
