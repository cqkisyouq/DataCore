using Microsoft.EntityFrameworkCore;
using MiniApps.Core.Base;
using MiniApps.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MiniApps.Core.Repositories
{
    public class EFRepository<TEntity,TId> : BaseRepository<TEntity> where TEntity :BaseEnity<TId>,IBaseEntity
    {
        public DbContext db { get; }
        public DbSet<TEntity> Entity { get; }
        public EFRepository(DbContext dbContext)
        {
            db = dbContext;
            Entity = db.Set<TEntity>();
        }

        public override int Delete(TEntity entity)
        {
            var dbEntity=db.Entry(entity);

            if (dbEntity.State == EntityState.Detached)
            {
                dbEntity.State = EntityState.Modified;
            }

            return db.SaveChanges();
        }

        public override int Delete(IEnumerable<TEntity> entities)
        {
            entities.AsParallel().ForAll(entity =>
            {
                var dbEntity = db.Entry(entity);
                if (dbEntity.State == EntityState.Detached) dbEntity.State = EntityState.Modified;
            });

            return db.SaveChanges();

        }

        public override IList<TEntity> GetEntities(Expression<Func<TEntity, bool>> expression)
        {
            return Entity.Where(expression).ToList();
        }

        public override TEntity GetEntity(object id)
        {
            return Entity.FirstOrDefault(x=>x.Id.Equals(id));
        }

        public override int Insert(TEntity entity)
        {
            Entity.Add(entity);
            return db.SaveChanges();
        }

        public override int Insert(IEnumerable<TEntity> entities)
        {
            Entity.AddRange(entities);

            return db.SaveChanges();
        }

        public override int Remove(TEntity entity)
        {
            Entity.Remove(entity);
            return db.SaveChanges();
        }

        public override int Remove(IEnumerable<TEntity> entities)
        {
            Entity.RemoveRange(entities);
            return db.SaveChanges();
        }

        public override int Update(TEntity entity)
        {
            Entity.Update(entity);
            return db.SaveChanges();
        }

        public override int Update(IEnumerable<TEntity> entities)
        {
            Entity.UpdateRange(entities);
            return db.SaveChanges();
        }
    }
}
