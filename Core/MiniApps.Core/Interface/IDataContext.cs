using System;
using System.Collections.Generic;
using System.Text;

namespace MiniApps.Core.Interface
{
    public interface IDataContext<TContext>
    {
        TContext Database { get; }
    }
}
