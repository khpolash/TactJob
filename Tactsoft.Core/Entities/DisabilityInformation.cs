using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class DisabilityInformation:BaseEntity
    {
        [Required]
        [Display(Name = "National Disability")]
        public string NationalDisabilityID { get; set; }
        [Required]
        [Display(Name = "Disability Details")]
        public string DisabilityDetails { get; set; }
        public long JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }
    }
}
