using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Entities;

namespace Tactsoft.Data.EntityConfigurations
{
	public class ReferenceConfigurations : IEntityTypeConfiguration<Reference>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Reference> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasOne(x => x.Jobseeker).WithMany(x => x.References).HasForeignKey(x => x.JobseekerId);
			builder.HasOne(x => x.Relative).WithMany(x => x.References).HasForeignKey(x => x.RelativeId);
		}
	}
}
