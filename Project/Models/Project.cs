using Project.Abstractions;
using Project.Shared;

namespace Project.Models
{
    public class Project : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Employee>? Employees { get; set; }
            = new HashSet<Employee>();

        public Interval Interval { get; set; }

    }
}
