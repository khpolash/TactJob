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
    public class CompanyConfigurations : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Country).WithMany(x => x.Companies).HasForeignKey(x => x.CountryId);
            builder.HasOne(x => x.IndustialType).WithMany(x => x.Companies).HasForeignKey(x => x.IndustialTypeId);
            builder.HasOne(x => x.CompanySize).WithMany(x => x.Companies).HasForeignKey(x => x.CompanySizeId);
            builder.HasOne(x => x.District).WithMany(x => x.Companies).HasForeignKey(x => x.DistrictId);
            builder.HasOne(x => x.Thana).WithMany(x => x.Companies).HasForeignKey(x => x.ThanaId);
		
		}
    }
}
