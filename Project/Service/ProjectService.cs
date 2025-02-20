using Project.Data;

namespace Project.Service
{
    public class ProjectService : Service<Models.Project>
    {
        public ProjectService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
