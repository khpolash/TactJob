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
    public class PhotographyConfigurations : IEntityTypeConfiguration<Photography>
    {
        public void Configure(EntityTypeBuilder<Photography> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.Photographies).HasForeignKey(x => x.JobseekerId);
        }
    }
}
