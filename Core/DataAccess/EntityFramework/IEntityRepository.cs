using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public interface IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        public TEntity Get(Expression<Func<TEntity, bool>> filter);
    }
}
