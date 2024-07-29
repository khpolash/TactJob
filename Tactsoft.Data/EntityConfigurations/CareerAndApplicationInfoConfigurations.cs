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
    public class CareerAndApplicationInfoConfigurations : IEntityTypeConfiguration<CareerAndApplicationInfo>
    {
        public void Configure(EntityTypeBuilder<CareerAndApplicationInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.careerAndApplicationInfos).HasForeignKey(x => x.JobseekerId);
        }
    }
}
