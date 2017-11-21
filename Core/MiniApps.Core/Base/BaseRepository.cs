using MiniApps.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace MiniApps.Core.Base
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IBaseEntity
    {
        public abstract int Delete(TEntity entity);
        public abstract int Delete(IEnumerable<TEntity> entities);
        public abstract IList<TEntity> GetEntities(Expression<Func<TEntity, bool>> expression);
        public abstract TEntity GetEntity(object id);
        public abstract int Insert(TEntity entity);
        public abstract int Insert(IEnumerable<TEntity> entities);
        public abstract int Remove(TEntity entity);
        public abstract int Remove(IEnumerable<TEntity> entities);
        public abstract int Update(TEntity entity);
        public abstract int Update(IEnumerable<TEntity> entities);
    }
}
