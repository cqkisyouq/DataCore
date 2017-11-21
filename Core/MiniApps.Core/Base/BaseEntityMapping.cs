using System;
using MiniApps.Core.Interface;

namespace MiniApps.Core.Base
{
    public abstract class BaseEntityMapping<TEntity> : IEntityMapping
    {
        public Type type => typeof(TEntity);
    }
}
