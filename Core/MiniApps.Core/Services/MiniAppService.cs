using MiniApps.Core.Base;
using MiniApps.Core.Interface;
using System;

namespace MiniApps.Core.Services
{
    public class MiniAppService<TEntity> : BaseService<TEntity> where TEntity : BaseEnity<Guid>
    {
        public MiniAppService(IRepository<TEntity> repository) : base(repository)
        {

        }
    }
}
