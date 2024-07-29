using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;

namespace Tactsoft.Data.EntityConfigurations
{
    public class JobApplicationConfigurations: IEntityTypeConfiguration<JobApplication>
    {
        public void Configure(EntityTypeBuilder<JobApplication> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.JobApplications).HasForeignKey(x => x.JobseekerId);
            builder.HasOne(x => x.PostingJobs).WithMany(x => x.JobApplications).HasForeignKey(x => x.PostingJobsId);
        }
    }
}