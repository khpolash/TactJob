using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class OtherRelevantInformation:BaseEntity
    {
        [Required]
        [Display(Name = "Career Summary")]
   
        public string CareerSummary { get; set; }
        [Required]
        [Display(Name = "Specia Qualification")]

        public string SpeciaQualification { get; set; }
        [Required]
        [Display(Name = "Keywords")]
        public string Keywords { get; set; }
        public long JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }
    }
}
