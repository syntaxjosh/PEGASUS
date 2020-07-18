using System;
using System.Linq;
using System.Threading.Tasks;
using Pegasus.Data;

namespace Pegasus.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly PegasusDbContext _pegasusDbContext;

        public Repository(PegasusDbContext pegasusDbContext)
        {
            _pegasusDbContext = pegasusDbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _pegasusDbContext.Set<TEntity>();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't retrieve entities");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _pegasusDbContext.AddAsync(entity);
                await _pegasusDbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be saved");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _pegasusDbContext.Update(entity);
                await _pegasusDbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be updated");
            }
        }
    }
}