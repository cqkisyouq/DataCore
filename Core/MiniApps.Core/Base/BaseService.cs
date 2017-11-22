using MiniApps.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace MiniApps.Core.Base
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
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

        public IQueryable<TEntity> Get(Func<IQueryable<TEntity>, IQueryable<TEntity>>  func=null)
        {
            var query = this._repository.Queryable;
            if (func == null) return query;
            query= func.Invoke(query);
            return query;
        }

        public TEntity GetById<TId>(TId id)
        {
            return _repository.GetEntity(id);
        }

        public IList<TEntity> GetByIds<TId>(IEnumerable<TId> ids)
        {
            if (ids == null || ids.Count() <= 0) return default(IList<TEntity>);

            var newIds=ids.Where(x=>!x.Equals(default(TId))).Select(x => (object)x);

            return _repository.GetEntities(newIds);
        }

        public IList<TEntity> GetEntities(Expression<Func<TEntity, bool>> func = null)
        {
            if (func == null) return this.Get().ToList();

            return this.Get(query => query.Where(func)).ToList();
        }

        public virtual TEntity GetEntity(Expression<Func<TEntity, bool>> func)
        {
            if (func == null) return default(TEntity);

            return this.Get(query=>query.Where(func)).FirstOrDefault();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            entity= _repository.Insert(entity);
            _repository.SaveChanges();
            return entity;
        }

        public virtual IEnumerable<TEntity> Insert(IEnumerable<TEntity> entities)
        {
            entities = _repository.Insert(entities);
            _repository.SaveChanges();
            return entities;
        }

        public virtual bool Remove(TEntity entity)
        {
            _repository.Remove(entity);

            return _repository.SaveChanges()==1;
        }

        public virtual bool Remove(IEnumerable<TEntity> entities)
        {
            _repository.Remove(entities);
            return  _repository.SaveChanges()>0;
        }

        public virtual bool Update(TEntity entity)
        {
            _repository.Update(entity);
            return _repository.SaveChanges()==1;
        }

        public virtual int Update(IEnumerable<TEntity> entities)
        {
             _repository.Update(entities);
            return _repository.SaveChanges();
        }
    }
}
