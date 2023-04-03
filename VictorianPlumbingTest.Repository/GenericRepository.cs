using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VictorianPlumbingTest.Repository.Context;

namespace VictorianPlumbingTest.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly VictorianPlumbingContext _context;

        public GenericRepository(VictorianPlumbingContext context)
        {
            _context = context;
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> Add(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            return result.Entity;
        }


        public void AddRange(IEnumerable<T> entity)
        {
            _context.AddRange(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}