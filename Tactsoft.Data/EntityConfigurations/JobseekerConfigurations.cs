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
    public class JobseekerConfigurations : IEntityTypeConfiguration<Jobseeker>
    {
        public void Configure(EntityTypeBuilder<Jobseeker> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.JobCategory).WithMany(x => x.Jobseekers).HasForeignKey(x => x.JobCategoryId);
        }
    }
}
