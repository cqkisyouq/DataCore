using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MiniApps.Core.Interface
{
    public interface IRepository { }
    public interface IRepository<TEntity>: IRepository where TEntity : class
    {
        
        IQueryable<TEntity> Queryable { get; }
        IQueryable<TEntity> QueryableNoTracking { get;}
        /// <summary>
        /// 根据条件获取实体集合
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IList<TEntity> GetEntities(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetEntity(object id);

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IList<TEntity> GetEntities(IEnumerable<object> ids);

        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(TEntity entity);
        /// <summary>
        /// 批量更新实体数据
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Update(IEnumerable<TEntity> entities);
        /// <summary>
        /// 添加一个新的实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Insert(TEntity entity);
        /// <summary>
        /// 指添加新实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Insert(IEnumerable<TEntity> entities);
        /// <summary>
        /// 删除一个实体 软删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Delete(TEntity entity);
        /// <summary>
        /// 指删除实体集 软删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Delete(IEnumerable<TEntity> entities);
        /// <summary>
        /// 删除一个实体数据 物理删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Remove(TEntity entity);
        /// <summary>
        /// 删除实体集 物理删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int Remove(IEnumerable<TEntity> entities);

        /// <summary>
        /// 执行存储
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}
