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
    public class AppliedJobConfigurations : IEntityTypeConfiguration<AppliedJob>
    {
        public void Configure(EntityTypeBuilder<AppliedJob> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.AppliedJobs).HasForeignKey(x => x.JobseekerId);
            builder.HasOne(x => x.PostingJobs).WithMany(x => x.AppliedJobs).HasForeignKey(x => x.PostingJobsId);
        }
    }
}
