using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MiniApps.Core.Extension;
using MiniApps.Core.Interface;
namespace MiniApps.Core.DataContext
{
    public class BaseDbContext : DbContext, IDataContext<DatabaseFacade>
    {
        public BaseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Register(GetType());
            base.OnModelCreating(modelBuilder);
        }
    }
}
