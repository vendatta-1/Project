using Project.Data;
using Project.Models;

namespace Project.Service
{
    public class DeparmtnetService : Service<Department>
    {
        public DeparmtnetService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
