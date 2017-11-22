using Microsoft.EntityFrameworkCore;
using MiniApps.Core.Extension;
using MiniApps.Core.Interface;
namespace MiniApps.Core.DataContext
{
    public class BaseDbContext : DbContext, IEFDataContext
    {
        public BaseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Register(GetType());
            base.OnModelCreating(modelBuilder);
        }
    }
}
