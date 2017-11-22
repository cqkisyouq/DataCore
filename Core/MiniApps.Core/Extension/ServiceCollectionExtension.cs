using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MiniApps.Core.Base;
using MiniApps.Core.DataContext;
using MiniApps.Core.Interface;
using MiniApps.Core.Mappings;
using MiniApps.Core.Repositories;
using MiniApps.Core.Services;

namespace MiniApps.Core.Extension
{
   public static class ServiceCollectionExtension
    {
        public static void AddEFMappings<TContext>(this IServiceCollection service, ServiceLifetime lifetime= ServiceLifetime.Scoped) where TContext: IEFDataContext
        {
           // service.AddTransient(typeof(IEntityMapping), typeof(EFEntityMapping<>));
            service.Add(new ServiceDescriptor(typeof(IRepository<>), typeof(EFRepository<>), lifetime));
            service.Add(new ServiceDescriptor(typeof(IEFDataContext), typeof(TContext), lifetime));
           // service.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        }
    }
}
