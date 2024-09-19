using BookStore.DAL.Context;
using BookStore.DAL.Entities;
using BookStore.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected QuizHubDatabaseContext _dbContext;

        protected BaseRepository(QuizHubDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<TEntity?> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync() 
        {  
            throw new NotImplementedException(); 
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
