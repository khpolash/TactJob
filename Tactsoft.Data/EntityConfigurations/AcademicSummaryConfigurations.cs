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
    public class AcademicSummaryConfigurations : IEntityTypeConfiguration<AcademicSummary>
    {
        public void Configure(EntityTypeBuilder<AcademicSummary> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.LevelofEducation).WithMany(x=>x.AcademicSummaries).HasForeignKey(x=>x.LevelofEducationId);
            builder.HasOne(x => x.degreeTitle).WithMany(x => x.AcademicSummaries).HasForeignKey(x => x.degreeTitleId);
            builder.HasOne(x => x.degreeTitle).WithMany(x => x.AcademicSummaries).HasForeignKey(x => x.degreeTitleId);
            builder.HasOne(x => x.board).WithMany(x => x.AcademicSummaries).HasForeignKey(x => x.boardId);
            builder.HasOne(x => x.Result).WithMany(x => x.AcademicSummaries).HasForeignKey(x => x.ResultId);
            builder.HasOne(x => x.YearOfPassing).WithMany(x => x.AcademicSummaries).HasForeignKey(x => x.YearOfPassingId);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.AcademicSummaries).HasForeignKey(x => x.JobseekerId);
        }
    }
}
