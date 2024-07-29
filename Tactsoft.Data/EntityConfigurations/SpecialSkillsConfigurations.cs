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
    public class SpecialSkillsConfigurations : IEntityTypeConfiguration<SpecialSkills>
    {
        public void Configure(EntityTypeBuilder<SpecialSkills> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
