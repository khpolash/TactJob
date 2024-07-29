using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tactsoft.Core.Base;

namespace Tactsoft.Core.Entities
{
    public class CareerAndApplicationInfo:BaseEntity
    {
        [Required]
        public string Objective { get; set; }
        [Required]
        public string PresentSalary { get; set; }
        [Required]
        public string ExpectedSalary { get; set; }
        [Required]
        public string JobLevel { get; set; }
        [Required]
        public string JobNature { get; set; }


        public long  JobseekerId { get; set; }

        public Jobseeker  Jobseeker { get; set; }
    }
}
