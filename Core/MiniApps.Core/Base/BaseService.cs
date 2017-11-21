using MiniApps.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MiniApps.Core.Base
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class,IBaseEntity
    {
        protected IRepository<TEntity> _repository;
        public BaseService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual bool Delete(TEntity entity)
        {
            return _repository.Delete(entity)==1;
        }

        public virtual bool Delete(IEnumerable<TEntity> entities)
        {
            return _repository.Delete(entities)>0;
        }

        public IList<TEntity> GetEntities(Expression<Func<TEntity, bool>> expression)
        {
            return _repository.GetEntities(expression);
        }

        public virtual TEntity GetEntity(object id)
        {
            return _repository.GetEntity(id);
        }

        public virtual TEntity Insert(TEntity entity)
        {
            return _repository.Insert(entity);
        }

        public virtual IEnumerable<TEntity> Insert(IEnumerable<TEntity> entities)
        {
            return _repository.Insert(entities);
        }

        public virtual bool Remove(TEntity entity)
        {
            return _repository.Remove(entity)==1;
        }

        public virtual bool Remove(IEnumerable<TEntity> entities)
        {
            return _repository.Remove(entities)>0;
        }

        public virtual bool Update(TEntity entity)
        {
            return _repository.Update(entity)==1;
        }

        public virtual int Update(IEnumerable<TEntity> entities)
        {
            return _repository.Update(entities);
        }
    }
}
