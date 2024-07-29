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
    public class CompanySizeConfigurations : IEntityTypeConfiguration<CompanySize>
    {
        public void Configure(EntityTypeBuilder<CompanySize> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
