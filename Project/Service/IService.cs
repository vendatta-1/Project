using Project.Abstractions;

namespace Project.Service
{
    //new means can make objects of this class
    public interface IService<T>
        where T : Entity, new()
    {
        public bool Insert(T entity);
        public T GetById(int id);
        public bool DeleteById(int id);
        public bool Delete(T entity);
        public bool Update(T entity);
        public bool DeleteAll();
        public IEnumerable<T> GetAll();
    }
}
