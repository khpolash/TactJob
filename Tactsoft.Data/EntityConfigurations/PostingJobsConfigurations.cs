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
    public class PostingJobsConfigurations : IEntityTypeConfiguration<PostingJobs>
    {
        public void Configure(EntityTypeBuilder<PostingJobs> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.JobCategory).WithMany(x => x.PostingJobs).HasForeignKey(x => x.JobCategoryeId);
            builder.HasOne(x => x.ServiceType).WithMany(x => x.PostingJobs).HasForeignKey(x => x.ServiceTypeId);
            builder.HasOne(x => x.IndustryType).WithMany(x => x.PostingJobs).HasForeignKey(x => x.IndustryTypeId);
            builder.HasOne(x => x.ResumeReceivingOption).WithMany(x => x.PostingJobs).HasForeignKey(x => x.ResumeReceivingOptionId);
			builder.HasOne(x => x.Company).WithMany(x => x.PostingJobs).HasForeignKey(x => x.CompanyId);


		}
	}
}
