using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class ProfessionalCertificationSummary:BaseEntity
    {
        [Required]
        public string Certification { get; set; }
        [Required]
        public string Institute { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime DurationStart { get; set; }
        [Required]
        public DateTime DurationEnd { get; set; }

        public long JobseekerId { get; set; }

        public Jobseeker Jobseeker { get; set; }
    }
}
