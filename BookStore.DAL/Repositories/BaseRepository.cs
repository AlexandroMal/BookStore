using BookStore.DAL.Context;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected AppDatabaseContext _dbContext;

        protected BaseRepository(AppDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TEntity?> GetByIdAsync(Guid Id)
        {
            var result = await _dbContext.Set<TEntity>().FindAsync(Id);
            return result;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync() 
        {
            var result = await _dbContext.Set<TEntity>().ToListAsync();
            return result;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var result = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            _dbContext.Set<TEntity>().Remove(result);
            await _dbContext.SaveChangesAsync();
        }
    }
}
