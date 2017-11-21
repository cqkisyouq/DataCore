using MiniApps.Core.Base;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MiniApps.Core.Mappings
{
    public  abstract class EFEntityMapping<TEntity> : BaseEntityMapping<TEntity>, IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);

    }
}
