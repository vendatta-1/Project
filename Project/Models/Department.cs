using Project.Abstractions;
using Project.Models.ValueObjects;

namespace Project.Models
{
    public class Department : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Employee> Employees { get; set; } =
            new HashSet<Employee>();

        public ICollection<Project> Projects { get; set; } =
            new HashSet<Project>();

        public Address Address { get; set; }
        //public Employee Manager { get; set; }
        public int ManagerId { get; set; }

    }
}
