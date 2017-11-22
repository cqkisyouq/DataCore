using EFDataAuth.Test.Domain.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MiniApps.Core.DataContext;

namespace EFDataAuth.Test.Domain
{
    public class MyTestDbContext: BaseDbContext
    {
        public MyTestDbContext(DbContextOptions<MyTestDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }
    }
}
