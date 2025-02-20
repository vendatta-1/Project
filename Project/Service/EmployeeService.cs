using Project.Data;
using Project.Models;

namespace Project.Service
{
    public class EmployeeService : Service<Employee>
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
