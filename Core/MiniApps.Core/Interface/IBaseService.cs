using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MiniApps.Core.Interface
{
    public interface IBaseService { }
    public interface IBaseService<TEntity>: IBaseService
    {
        IQueryable<TEntity> Get(Func<IQueryable<TEntity>, IQueryable<TEntity>> func);

        /// <summary>
        /// 根据ID 获取对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById<TId>(TId id);

        /// <summary>
        /// 根据ID列表获取对象集
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        IList<TEntity> GetByIds<TId>(IEnumerable<TId> ids);
        /// <summary>
        /// 根据条件获取实体集合
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IList<TEntity> GetEntities(Expression<Func<TEntity, bool>> func);

        /// <summary>
        /// 根据条件获取实体
        /// </summary>
        /// <param name="func">条件</param>
        /// <returns></returns>
        TEntity GetEntity(Expression<Func<TEntity, bool>> func);
        /// <summary>
        /// 更新实体数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Update(TEntity entity);
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
        bool Delete(TEntity entity);
        /// <summary>
        /// 指删除实体集 软删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        bool Delete(IEnumerable<TEntity> entities);
        /// <summary>
        /// 删除一个实体数据 物理删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Remove(TEntity entity);
        /// <summary>
        /// 删除实体集 物理删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        bool Remove(IEnumerable<TEntity> entities);

    }
}