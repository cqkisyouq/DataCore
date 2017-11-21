using MiniApps.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;
using MiniApps.Core.Interface;

namespace MiniApps.Core.Services
{
    public class MiniAppService<TEntity> : BaseService<TEntity> where TEntity : BaseEnity<Guid>
    {
        public MiniAppService(IRepository<TEntity> repository) : base(repository)
        {

        }
    }
}
