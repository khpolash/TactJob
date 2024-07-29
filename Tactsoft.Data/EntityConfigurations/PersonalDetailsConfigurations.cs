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
    public class PersonalDetailsConfigurations : IEntityTypeConfiguration<PersonalDetails>
    {
        public void Configure(EntityTypeBuilder<PersonalDetails> builder)
        {
           builder.HasKey(x=> x.Id);
            builder.HasOne(x => x.BloodGroup).WithMany(x => x.PersonalDetails).HasForeignKey(x => x.BloodGroupId);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.PersonalDetails).HasForeignKey(x => x.JobseekerId);

        }
    }
}
