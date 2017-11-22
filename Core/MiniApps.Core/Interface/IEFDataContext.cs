using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniApps.Core.Interface
{
    public interface IEFDataContext:IDataContext<DatabaseFacade>
    {
        DbSet<TEntity> Set<TEntity>() where TEntity:class;
        EntityEntry Entry(object entity);
        int SaveChanges();
    }
}
