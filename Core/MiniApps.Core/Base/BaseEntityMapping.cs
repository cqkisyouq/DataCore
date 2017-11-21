using MiniApps.Core.Interface;

namespace MiniApps.Core.Base
{
    public abstract class BaseEntityMapping<TEntity> : IEntityMapping<TEntity>
    {
        public abstract void Configure(TEntity builder);
    }
}
