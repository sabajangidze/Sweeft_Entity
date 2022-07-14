using School.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repository
{
    public abstract class BaseRepository<TEntity, TKey> where TEntity : BaseModel<TKey>
    {
        private SchoolDbContext _dbContext;
        private DbSet<TEntity> _entity;

        public BaseRepository()
        {
            _dbContext = new SchoolDbContext();
            _entity = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entity.AsNoTracking();
        }
    }
}
