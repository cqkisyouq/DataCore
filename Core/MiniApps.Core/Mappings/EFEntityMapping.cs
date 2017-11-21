using MiniApps.Core.Base;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MiniApps.Core.Mappings
{
    public  class EFEntityMapping<TEntity> : BaseEntityMapping<TEntity>, IEntityTypeConfiguration<TEntity> where TEntity : class
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder) { }

    }
}
