using System.Collections.Generic;
using System.Threading.Tasks;

namespace VictorianPlumbingTest.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        void AddRange(IEnumerable<T> entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
