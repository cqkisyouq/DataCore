using MiniApps.Core.Base;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MiniApps.Core.Mappings
{
    public class EFEntityMapping<TEntity> : BaseEntityMapping<TEntity>, IEntityTypeConfiguration<TEntity> where TEntity : EntityTypeBuilder<TEntity>
    {
        public override void Configure(TEntity builder)
        {
            throw new NotImplementedException();
        }
    }
}
