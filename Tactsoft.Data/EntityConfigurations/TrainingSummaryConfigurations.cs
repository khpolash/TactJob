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
    public class TrainingSummaryConfigurations : IEntityTypeConfiguration<TrainingSummary>
    {
        public void Configure(EntityTypeBuilder<TrainingSummary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.country).WithMany(x=>x.TrainingSummaries).HasForeignKey(x=>x.CountryId);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.TrainingSummaries).HasForeignKey(x => x.JobseekerId);
            builder.HasOne(x => x.YearOfPassing).WithMany(x => x.TrainingSummaries).HasForeignKey(x => x.YearId);

        }
    }
}
