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
    public class PreferredAreasConfigurations : IEntityTypeConfiguration<PreferredAreas>
    {
        public void Configure(EntityTypeBuilder<PreferredAreas> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.PreferredAreas).HasForeignKey(x => x.JobseekerId);
            builder.HasOne(x => x.Country).WithMany(x => x.PreferredAreas).HasForeignKey(x => x.CountryId);
            builder.HasOne(x => x.District).WithMany(x => x.PreferredAreas).HasForeignKey(x => x.DistrictId);
            builder.HasOne(x => x.SpecialSkills).WithMany(x => x.PreferredAreas).HasForeignKey(x => x.SpecialSkillsId);
            builder.HasOne(x => x.JobCategory).WithMany(x => x.PreferredAreas).HasForeignKey(x => x.JobCategoryId);
            builder.HasOne(x => x.Organization).WithMany(x => x.areas).HasForeignKey(x => x.OrganizationId);
        }
    }
}
