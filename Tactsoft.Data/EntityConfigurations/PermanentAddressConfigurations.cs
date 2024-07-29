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
    public class PermanentAddressConfigurations : IEntityTypeConfiguration<PermanentAddress>
    {
        public void Configure(EntityTypeBuilder<PermanentAddress> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Jobseeker).WithMany(x => x.PermanentAddresses).HasForeignKey(x => x.JobseekerId);
            builder.HasOne(x => x.Country).WithMany(x => x.PermanentAddresses).HasForeignKey(x => x.CountryId);
            builder.HasOne(x => x.District).WithMany(x => x.PermanentAddresses).HasForeignKey(x => x.DistrictId);
            builder.HasOne(x => x.Thana).WithMany(x => x.PermanentAddresses).HasForeignKey(x => x.ThanaId);
            builder.HasOne(x => x.Board).WithMany(x => x.PermanentAddresses).HasForeignKey(x => x.BoardId);
        }
    }
}
