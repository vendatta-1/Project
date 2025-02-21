using Project.Abstractions;
using Project.Data;

namespace Project.Service
{
    public class Service<T> : IService<T>
        where T : Entity, new()
    {
        // DbContext _context 
        private readonly ApplicationDbContext _context;
        public Service(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public bool Delete(T entity)
        {
            _context.Set<T>().Remove(entity);

            return _context.SaveChanges() > 0;

        }

        public bool DeleteAll()
        {
            var all = _context.Set<T>().ToList();
            _context.Set<T>().RemoveRange(all);

            return _context.SaveChanges() > 0;
        }

        public bool DeleteById(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public IEnumerable<T?> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            var entity = _context.Set<T>().Find(new { id });
            return entity;
        }

        public bool Insert(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

        }

        public bool Update(T entity)
        {
            _context.Set<T>()
                .Update(entity);
            return _context.SaveChanges() > 0;
        }
    }
}
