using MiniApps.Core.Base;
using MiniApps.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDataAuth.Test.Domain.Data
{
    public class BaseModel: BaseEnity<Guid>
    {
        public BaseModel()
        {
            Id = Guid.NewGuid();
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
            Order = 1;
        }
    }
}
