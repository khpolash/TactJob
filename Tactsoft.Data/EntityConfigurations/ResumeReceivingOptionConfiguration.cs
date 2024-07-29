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
    public class ResumeReceivingOptionConfiguration : IEntityTypeConfiguration<ResumeReceivingOption>
    {
        public void Configure(EntityTypeBuilder<ResumeReceivingOption> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
