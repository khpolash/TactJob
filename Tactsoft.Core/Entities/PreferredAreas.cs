using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class PreferredAreas:BaseEntity
    {
        [Required]
        public long JobCategoryId { get; set; }
        [Required]
        public  JobCategory JobCategory { get; set; }
        [Required]
        public long SpecialSkillsId { get; set; }
        public SpecialSkills SpecialSkills { get; set; }
        [Required]
        public long DistrictId { get; set; }
        public District District { get; set; }
        [Required]
        public long CountryId { get; set; }
        public Country Country { get; set; }
        [Required]

        public long OrganizationId { get; set; }
        public OrganizationType  Organization { get; set; }


        public long JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }
    }
}
