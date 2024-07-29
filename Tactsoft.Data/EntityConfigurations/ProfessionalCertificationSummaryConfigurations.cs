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
    public class ProfessionalCertificationSummaryConfigurations : IEntityTypeConfiguration<ProfessionalCertificationSummary>
    {
        public void Configure(EntityTypeBuilder<ProfessionalCertificationSummary> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.ProfessionalCertificationSummary).HasForeignKey(x => x.JobseekerId);
        }
    }
}
