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
    public class DisabilityInformationConfigurations : IEntityTypeConfiguration<DisabilityInformation>
    {
        public void Configure(EntityTypeBuilder<DisabilityInformation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.DisabilityInformation).HasForeignKey(x => x.JobseekerId);
        }
    }
}
