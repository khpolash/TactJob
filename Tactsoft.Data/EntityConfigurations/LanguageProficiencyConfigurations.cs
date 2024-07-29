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
	public class LanguageProficiencyConfigurations : IEntityTypeConfiguration<LanguageProficiency>
	{
		public void Configure(EntityTypeBuilder<LanguageProficiency> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasOne(x=>x.Writing).WithMany(x=>x.LanguageProficiencies).HasForeignKey(x=>x.WritingId);
			builder.HasOne(x => x.Reading).WithMany(x => x.LanguageProficiencies).HasForeignKey(x => x.ReadingId);
			builder.HasOne(x => x.Speaking).WithMany(x => x.LanguageProficiencies).HasForeignKey(x => x.SpeakingId);
			builder.HasOne(x => x.Jobseeker).WithMany(x => x.LanguageProficiencies).HasForeignKey(x => x.JobseekerId);


		}
	}
}
