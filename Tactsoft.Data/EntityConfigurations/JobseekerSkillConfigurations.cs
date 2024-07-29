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
    public class JobseekerSkillConfigurations : IEntityTypeConfiguration<JobseekerSkill>
    {
        public void Configure(EntityTypeBuilder<JobseekerSkill> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.JobseekerSkills).HasForeignKey(x => x.JobseekerId);
        }
    }
}
