using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Linq;
using System.Collections.Generic;
using MiniApps.Core;
using MiniApps.Core.Mappings;
using MiniApps.Core.Interface;

namespace MiniApps.Core.Extension
{
    public static class ModelBuilderExtension
    {
        public static readonly MethodInfo Configuration = typeof(ModelBuilderExtension).GetMethod(nameof(ApplyConfiguration));

        

        public static void Register(this ModelBuilder modelBuilder,Type type)
        {
            var types = type.Assembly.GetTypes();
            var _Mappings= types.Where(x =>typeof(IEntityMapping).IsAssignableFrom(x)).ToList();

            _Mappings.ForEach(mapping =>
            {
                var item= Activator.CreateInstance(mapping);
                var entityType = (item as IEntityMapping).type;
                var method = Configuration.MakeGenericMethod(entityType);
                Configuration.MakeGenericMethod(entityType).Invoke(null, new object[] { modelBuilder,item });
            });
        }
        
        public static void ApplyConfiguration<T>(ModelBuilder modelBuilder,IEntityTypeConfiguration<T>  entityTypeConfiguration) where T:class
        {
            modelBuilder.ApplyConfiguration(entityTypeConfiguration);
        }
    }
}
