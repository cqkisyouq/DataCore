using EFDataAuth.Test.Domain.Data;
using MiniApps.Core.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataTest.Domain.Mapp
{
    public class UserMapping : EFEntityMapping<Users>
    {
        public override void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Ignore(x => x.Deleted);
            builder.Ignore(x => x.Enabled);
            builder.Ignore(x => x.Description);
        }
        
    }
}
