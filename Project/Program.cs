using Project.Models;
using Project.Models.ValueObjects;
using Project.Shared;

namespace Project;
public class Program
{
    public static void Main()
    {
        // data stored in binary 
        // convert binary to read format ( json , xml )

        Employee employee = new Employee()
        {
            Id = 1,
            FirstName = "Abdullah",
            LastName = "Musa",
            Age = 30,
            DepartmentId = 1,
            Type = EmployeeType.FullTime,
            Address = new Address("123 Main St", "Anytown", "CA", "USA", "12345"),
            Supervisor = new Employee() { Id = 2, FirstName = "John", LastName = "Doe" },
            Projects = new List<Models.Project> { new Models.Project() { Name = "Project 1",
                Interval = new Interval(DateOnly.FromDateTime (DateTime.Today),DateOnly.FromDateTime( DateTime.Today.AddDays(100))) } },
            Interval = new Interval(DateOnly.FromDateTime(DateTime.Today), DateOnly.FromDateTime(DateTime.Today.AddMonths(100))),
            Salary = 50000m,

        };
        var department = new Department()
        {
            Id = 1,
            Name = "IT",
            Employees = new List<Employee> { employee },
            Projects = new List<Models.Project> { new Models.Project() { Name = "Project 1",
                Interval = new Interval(DateOnly.FromDateTime (DateTime.Today),DateOnly.FromDateTime( DateTime.Today.AddDays(100))) } }
        };


    }
}


/// first must have a department without ProjectList and EmployeeList
/// Employee without projectList
/// Project without  EmployeeList