using Microsoft.Extensions.DependencyInjection;
using MiniApps.Core.Base;
using MiniApps.Core.Interface;
using MiniApps.Core.Mappings;
using MiniApps.Core.Repositories;
using MiniApps.Core.Services;

namespace MiniApps.Core.Extension
{
   public static class ServiceCollectionExtension
    {
        public static void AddEFMappings(this IServiceCollection service)
        {
           // service.AddTransient(typeof(IEntityMapping), typeof(EFEntityMapping<>));
            service.AddSingleton(typeof(IRepository<>), typeof(EFRepository<>));
           // service.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
        }
    }
}
