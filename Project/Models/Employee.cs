using Project.Abstractions;
using Project.Models.ValueObjects;
using Project.Shared;

namespace Project.Models
{
    public class Employee : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Address Address { get; set; }
        public ICollection<Employee>? Employees { get; set; }
            = new HashSet<Employee>();
        public int? SupervisiorId { get; set; }

        public Employee? Supervisor { get; set; }

        public ICollection<Project>? Projects { get; set; }
               = new HashSet<Project>();


        public string Phone { get; set; }
        public decimal Salary { get; set; }

        public Interval Interval { get; set; }
        public EmployeeType Type { get; set; }


    }
}
