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
    public class IndustryTypeConfigurations : IEntityTypeConfiguration<IndustryType>
    {
        public void Configure(EntityTypeBuilder<IndustryType> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
