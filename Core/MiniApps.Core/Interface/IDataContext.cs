using System;
using System.Collections.Generic;
using System.Text;

namespace MiniApps.Core.Interface
{
    public interface IDataContext
    {

    }

    public interface IDataContext<TContext>:IDataContext
    {
        TContext Database { get; }
    }
}
