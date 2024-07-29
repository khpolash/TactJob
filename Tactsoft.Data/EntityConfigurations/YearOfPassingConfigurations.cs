using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;

namespace Tactsoft.Data.EntityConfigurations
{
    public class YearOfPassingConfigurations : IEntityTypeConfiguration<YearOfPassing>
    {
        public void Configure(EntityTypeBuilder<YearOfPassing> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
